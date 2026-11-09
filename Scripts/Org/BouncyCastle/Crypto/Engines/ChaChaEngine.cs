using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class ChaChaEngine : Salsa20Engine
    {
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public ChaChaEngine()
        {
        
        }
        public ChaChaEngine(int rounds)
        {
        
        }
        public override string get_AlgorithmName()
        {
            return (string)"ChaCha" + true;
        }
        protected override void AdvanceCounter()
        {
            var val_1 = this;
            var val_1 = X20 + 80;
            val_1 = val_1 + 1;
            mem2[0] = val_1;
            if(val_1 != 0)
            {
                    return;
            }
            
            val_1 = val_1 + 1;
            mem[1152921551498101652] = val_1;
        }
        protected override void ResetCounter()
        {
            var val_1 = mem[X19 + 24];
            val_1 = X19 + 24;
            if(val_1 <= 13)
            {
                    val_1 = mem[X19 + 24];
                val_1 = X19 + 24;
            }
            
            mem2[0] = 0;
            mem2[0] = 0;
        }
        protected override void SetKey(byte[] keyBytes, byte[] ivBytes)
        {
            if(keyBytes != null)
            {
                    if(keyBytes.Length != 16)
            {
                    if(keyBytes.Length != 32)
            {
                goto label_3;
            }
            
            }
            
                15131.PackTauOrSigma(keyLength:  keyBytes.Length, state:  ivBytes, stateOffset:  0);
                Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  keyBytes, bOff:  0, ns:  ivBytes, nOff:  4, count:  4);
                Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  keyBytes, bOff:  keyBytes.Length - 16, ns:  ivBytes, nOff:  8, count:  4);
            }
            else
            {
                    this = 1152921551498408680;
            }
            
            Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  ivBytes, bOff:  0, ns:  null, nOff:  14, count:  2);
            return;
            label_3:
            System.ArgumentException val_3 = new System.ArgumentException(message:  this + " requires 128 bit or 256 bit key");
        }
        protected override void GenerateKeyStream(byte[] output)
        {
            Org.BouncyCastle.Crypto.Engines.ChaChaEngine.ChachaCore(rounds:  -352847792, input:  X8, x:  null);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(ns:  this, bs:  output, off:  0);
        }
        internal static void ChachaCore(int rounds, uint[] input, uint[] x)
        {
            int val_53;
            uint val_54;
            uint val_55;
            uint val_56;
            uint val_57;
            uint val_58;
            uint val_59;
            uint val_60;
            uint val_61;
            uint val_62;
            uint val_63;
            uint val_64;
            uint val_65;
            uint val_66;
            uint val_67;
            uint val_68;
            uint val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            uint val_78;
            uint val_79;
            uint val_80;
            uint val_81;
            uint val_82;
            uint val_83;
            uint val_84;
            uint val_85;
            uint val_86;
            uint val_87;
            uint val_88;
            var val_89;
            uint val_90;
            uint val_91;
            var val_92;
            uint val_93;
            var val_94;
            var val_95;
            var val_96;
            uint val_97;
            uint val_98;
            uint val_99;
            uint val_100;
            var val_101;
            var val_102;
            if((input.Length != 16) || (x.Length != 16))
            {
                goto label_4;
            }
            
            if((rounds & 1) != 0)
            {
                goto label_5;
            }
            
            val_53 = input.Length;
            if(val_53 == 0)
            {
                    val_53 = input.Length;
            }
            
            val_54 = input[0];
            if(val_53 <= 1)
            {
                    val_53 = input.Length;
            }
            
            val_55 = input[0];
            if(val_53 <= 2)
            {
                    val_55 = val_55;
                val_53 = input.Length;
            }
            
            val_56 = input[1];
            if(val_53 <= 3)
            {
                    val_55 = val_55;
                val_56 = val_56;
                val_53 = input.Length;
            }
            
            val_57 = input[1];
            if(val_53 <= 4)
            {
                    val_55 = val_55;
                val_56 = val_56;
                val_57 = val_57;
                val_53 = input.Length;
            }
            
            val_58 = input[2];
            if(val_53 <= 5)
            {
                    val_55 = val_55;
                val_56 = val_56;
                val_57 = val_57;
                val_58 = val_58;
                val_53 = input.Length;
            }
            
            val_59 = input[2];
            if(val_53 <= 6)
            {
                    val_55 = val_55;
                val_56 = val_56;
                val_57 = val_57;
                val_58 = val_58;
                val_59 = val_59;
                val_53 = input.Length;
            }
            
            val_60 = input[3];
            if(val_53 <= 7)
            {
                    val_55 = val_55;
                val_56 = val_56;
                val_57 = val_57;
                val_58 = val_58;
                val_59 = val_59;
                val_53 = input.Length;
            }
            
            val_61 = input[3];
            if(val_53 <= 8)
            {
                    val_55 = val_55;
                val_56 = val_56;
                val_57 = val_57;
                val_58 = val_58;
                val_59 = val_59;
                val_53 = input.Length;
            }
            
            val_62 = input[4];
            if(val_53 <= 9)
            {
                    val_55 = val_55;
                val_56 = val_56;
                val_57 = val_57;
                val_58 = val_58;
                val_59 = val_59;
                val_53 = input.Length;
            }
            
            val_63 = input[4];
            if(val_53 <= 10)
            {
                    val_55 = val_55;
                val_56 = val_56;
                val_57 = val_57;
                val_58 = val_58;
                val_59 = val_59;
                val_53 = input.Length;
            }
            
            val_64 = input[5];
            if(val_53 <= 11)
            {
                    val_55 = val_55;
                val_56 = val_56;
                val_57 = val_57;
                val_58 = val_58;
                val_59 = val_59;
                val_53 = input.Length;
            }
            
            val_65 = input[5];
            if(val_53 <= 12)
            {
                    val_55 = val_55;
                val_56 = val_56;
                val_57 = val_57;
                val_58 = val_58;
                val_59 = val_59;
                val_53 = input.Length;
            }
            
            val_66 = input[6];
            if(val_53 <= 13)
            {
                    val_55 = val_55;
                val_56 = val_56;
                val_57 = val_57;
                val_58 = val_58;
                val_59 = val_59;
                val_53 = input.Length;
                val_66 = val_66;
            }
            
            val_67 = input[6];
            if(val_53 <= 14)
            {
                    val_55 = val_55;
                val_56 = val_56;
                val_57 = val_57;
                val_58 = val_58;
                val_59 = val_59;
                val_53 = input.Length;
                val_66 = val_66;
            }
            
            val_68 = input[7];
            if(val_53 <= 15)
            {
                    val_55 = val_55;
                val_56 = val_56;
                val_57 = val_57;
                val_58 = val_58;
                val_59 = val_59;
                val_66 = val_66;
            }
            
            val_69 = input[7];
            if(rounds >= 1)
            {
                    val_70 = 1152921505536983040;
                int val_1 = rounds + 2;
                do
            {
                val_54 = val_54 + val_58;
                val_70 = val_70;
                val_71 = val_55;
                val_72 = val_56;
                val_73 = val_57;
                val_74 = val_58;
                val_75 = val_66;
                val_76 = val_59;
                val_77 = val_69;
                val_79 = val_68;
                val_78 = val_67;
                val_81 = val_65;
                val_80 = val_64;
                val_83 = val_63;
                val_82 = val_62;
                val_84 = val_60;
                val_85 = val_61;
                uint val_2 = val_54 ^ val_75;
                uint val_3 = val_71 + val_76;
                uint val_4 = val_72 + val_84;
                uint val_5 = val_73 + val_85;
                uint val_6 = val_2 >> 16;
                uint val_7 = val_3 ^ val_78;
                uint val_8 = val_4 ^ val_79;
                val_77 = val_5 ^ val_77;
                val_6 = val_6 + val_82;
                uint val_9 = val_7 >> 16;
                uint val_10 = val_8 >> 16;
                uint val_11 = val_77 >> 16;
                uint val_12 = val_6 ^ val_74;
                val_9 = val_9 + val_83;
                val_10 = val_10 + val_80;
                val_11 = val_11 + val_81;
                val_74 = val_12 >> 20;
                val_76 = val_9 ^ val_76;
                uint val_13 = val_10 ^ val_84;
                uint val_14 = val_11 ^ val_85;
                val_74 = val_74 + val_54;
                val_72 = val_13 >> 20;
                uint val_16 = val_14 >> 20;
                val_2 = val_74 ^ (((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[6])) << 16));
                val_3 = (val_76 >> 20) + val_3;
                val_4 = val_72 + val_4;
                val_5 = val_16 + val_5;
                val_7 = val_3 ^ (((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[6])) << 16));
                val_8 = val_4 ^ (((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[7])) << 16));
                val_77 = val_5 ^ (((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[7])) << 16));
                val_6 = (val_2 >> 24) + val_6;
                val_72 = val_8 >> 24;
                val_16 = val_77 >> 24;
                val_9 = (val_7 >> 24) + val_9;
                val_10 = val_72 + val_10;
                val_11 = val_16 + val_11;
                val_12 = val_6 ^ ((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2])) << (32-20)) | (((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2])) << 20));
                val_76 = val_9 ^ ((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2])) << (32-20)) | (((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2])) << 20));
                val_13 = val_10 ^ ((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3])) << (32-20)) | (((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3])) << 20));
                val_14 = val_11 ^ ((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3])) << (32-20)) | (((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3])) << 20));
                uint val_19 = val_12 >> 25;
                uint val_20 = val_76 >> 25;
                uint val_21 = val_13 >> 25;
                uint val_22 = val_14 >> 25;
                val_5 = val_19 + val_5;
                val_74 = val_20 + val_74;
                val_3 = val_21 + val_3;
                val_4 = val_22 + val_4;
                uint val_25 = val_3 ^ (((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[6])) << 1) << (32-24)) | ((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[6])) << 1) << 24));
                val_19 = (val_5 ^ (((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[7])) << 1) << (32-24)) | ((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[7])) << 1) << 24))) >> 16;
                val_20 = (val_74 ^ (((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[7])) << 1) << (32-24)) | ((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[7])) << 1) << 24))) >> 16;
                val_21 = val_25 >> 16;
                val_22 = (val_4 ^ (((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[6])) << 1) << (32-24)) | ((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[6])) << 1) << 24))) >> 16;
                uint val_27 = val_19;
                uint val_28 = val_20;
                uint val_29 = val_21;
                uint val_30 = val_22;
                val_12 = val_27 ^ ((((((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[6])) <) << (32-25)) | (((((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[6])) <) << 25));
                val_76 = val_28 ^ ((((((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[6])) <) << (32-25)) | (((((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[6])) <) << 25));
                val_13 = val_29 ^ ((((((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[7])) <) << (32-25)) | (((((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[7])) <) << 25));
                val_14 = val_30 ^ ((((((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[7])) <) << (32-25)) | (((((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[7])) <) << 25));
                val_19 = val_12 >> 20;
                val_20 = val_76 >> 20;
                val_21 = val_13 >> 20;
                val_22 = val_14 >> 20;
                val_86 = val_19 + val_5;
                val_54 = val_20 + val_74;
                val_87 = val_21 + val_3;
                val_88 = val_22 + val_4;
                val_25 = val_87 ^ (((((((((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((((((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[7])) << 16));
                uint val_33 = val_88 ^ (((((((((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((((((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[7])) << 16));
                val_89 = (val_86 ^ (((((((((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((((((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[6])) << 16))) >> 24;
                val_90 = (val_54 ^ (((((((((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((((((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[6])) << 16))) >> 24;
                val_91 = val_25 >> 24;
                val_92 = val_33 >> 24;
                val_93 = val_89 + val_27;
                val_94 = val_90 + val_28;
                val_95 = val_91 + val_29;
                val_96 = val_92 + val_30;
                val_1 = val_1 - 2;
                val_33 = val_96 ^ ((((((((((((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[) << (32-20)) | (((((((((((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[) << 20));
                val_97 = (val_94 ^ ((((((((((((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[) << (32-20)) | (((((((((((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[) << 20))) >> 25;
                val_98 = (val_95 ^ ((((((((((((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[) << (32-20)) | (((((((((((((((((((input[1] + input[3]) ^ input[7]) >> 16) + input[5]) ^ input[3]) >> 20) + (input[1] + input[3])) ^ ((((input[1] + input[3]) ^ input[7])) << (32-16)) | ((((input[1] + input[3]) ^ input[) << 20))) >> 25;
                val_99 = val_33 >> 25;
                val_100 = (val_93 ^ ((((((((((((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[) << (32-20)) | (((((((((((((((((((input[0] + input[2]) ^ input[6]) >> 16) + input[4]) ^ input[2]) >> 20) + (input[0] + input[2])) ^ ((((input[0] + input[2]) ^ input[6])) << (32-16)) | ((((input[0] + input[2]) ^ input[) << 20))) >> 25;
            }
            while(val_1 > 2);
            
            }
            
            if(input == 0)
            {
                    val_87 = val_87;
                val_88 = val_88;
                val_86 = val_86;
                val_100 = val_100;
                val_97 = val_97;
                val_91 = val_91;
                val_90 = val_90;
            }
            
            if((input + 24) == 0)
            {
                    val_87 = val_87;
                val_88 = val_88;
                val_86 = val_86;
                val_100 = val_100;
                val_97 = val_97;
                val_91 = val_91;
                val_90 = val_90;
            }
            
            val_101 = mem[input + 32];
            val_101 = input + 32;
            if(x == 0)
            {
                    val_101 = val_101;
                val_87 = val_87;
                val_88 = val_88;
                val_86 = val_86;
                val_100 = val_100;
                val_97 = val_97;
                val_91 = val_91;
                val_90 = val_90;
            }
            
            val_54 = val_101 + val_54;
            if((x + 24) == 0)
            {
                    val_87 = val_87;
                val_88 = val_88;
                val_86 = val_86;
                val_100 = val_100;
                val_97 = val_97;
                val_91 = val_91;
                val_90 = val_90;
            }
            
            mem2[0] = val_54;
            if((input + 24) <= 1)
            {
                    val_87 = val_87;
                val_88 = val_88;
                val_86 = val_86;
                val_100 = val_100;
                val_97 = val_97;
                val_91 = val_91;
                val_90 = val_90;
            }
            
            if((x + 24) <= 1)
            {
                    val_88 = val_88;
                val_86 = val_86;
                val_100 = val_100;
                val_97 = val_97;
                val_91 = val_91;
                val_90 = val_90;
            }
            
            mem2[0] = (input + 36) + val_87;
            if((input + 24) <= 2)
            {
                    val_88 = val_88;
                val_86 = val_86;
                val_100 = val_100;
                val_97 = val_97;
                val_91 = val_91;
                val_90 = val_90;
            }
            
            if((x + 24) <= 2)
            {
                    val_86 = val_86;
                val_100 = val_100;
                val_97 = val_97;
                val_91 = val_91;
                val_90 = val_90;
            }
            
            mem2[0] = (input + 40) + val_88;
            if((input + 24) <= 3)
            {
                    val_86 = val_86;
                val_100 = val_100;
                val_97 = val_97;
                val_91 = val_91;
                val_90 = val_90;
            }
            
            if((x + 24) <= 3)
            {
                    val_100 = val_100;
                val_97 = val_97;
                val_91 = val_91;
                val_90 = val_90;
            }
            
            mem2[0] = (input + 44) + val_86;
            if((input + 24) <= 4)
            {
                    val_100 = val_100;
                val_97 = val_97;
                val_91 = val_91;
                val_90 = val_90;
            }
            
            val_93 = (input + 48) + val_100;
            if((x + 24) <= 4)
            {
                    val_97 = val_97;
                val_91 = val_91;
                val_90 = val_90;
            }
            
            mem2[0] = val_93;
            if((input + 24) <= 5)
            {
                    val_97 = val_97;
                val_91 = val_91;
                val_90 = val_90;
            }
            
            if((x + 24) <= 5)
            {
                    val_91 = val_91;
                val_90 = val_90;
            }
            
            mem2[0] = (input + 52) + val_97;
            if((input + 24) <= 6)
            {
                    val_91 = val_91;
                val_90 = val_90;
            }
            
            if((x + 24) <= 6)
            {
                    val_91 = val_91;
                val_90 = val_90;
            }
            
            mem2[0] = (input + 56) + val_98;
            if((input + 24) <= 7)
            {
                    val_91 = val_91;
                val_90 = val_90;
            }
            
            if((x + 24) <= 7)
            {
                    val_91 = val_91;
                val_90 = val_90;
            }
            
            mem2[0] = (input + 60) + val_99;
            if((input + 24) <= 8)
            {
                    val_91 = val_91;
                val_90 = val_90;
            }
            
            if((x + 24) <= 8)
            {
                    val_91 = val_91;
                val_90 = val_90;
            }
            
            mem2[0] = (input + 64) + val_96;
            if((input + 24) <= 9)
            {
                    val_91 = val_91;
                val_90 = val_90;
            }
            
            if((x + 24) <= 9)
            {
                    val_91 = val_91;
                val_90 = val_90;
            }
            
            mem2[0] = (input + 68) + val_93;
            if((input + 24) <= 10)
            {
                    val_91 = val_91;
                val_90 = val_90;
            }
            
            if((x + 24) <= 10)
            {
                    val_91 = val_91;
                val_90 = val_90;
            }
            
            mem2[0] = (input + 72) + val_94;
            if((input + 24) <= 11)
            {
                    val_91 = val_91;
                val_90 = val_90;
            }
            
            if((x + 24) <= 11)
            {
                    val_91 = val_91;
                val_90 = val_90;
            }
            
            mem2[0] = (input + 76) + val_95;
            if((input + 24) <= 12)
            {
                    val_91 = val_91;
                val_90 = val_90;
            }
            
            if((x + 24) <= 12)
            {
                    val_90 = val_90;
            }
            
            mem2[0] = (input + 80) + val_91;
            if((input + 24) <= 13)
            {
                    val_90 = val_90;
            }
            
            if((x + 24) <= 13)
            {
                    val_90 = val_90;
            }
            
            mem2[0] = (input + 84) + val_92;
            if((input + 24) <= 14)
            {
                    val_90 = val_90;
            }
            
            if((x + 24) <= 14)
            {
                    val_90 = val_90;
            }
            
            mem2[0] = (input + 88) + val_89;
            if((input + 24) <= 15)
            {
                    val_90 = val_90;
            }
            
            mem2[0] = (input + 92) + val_90;
            return;
            label_4:
            System.ArgumentException val_51 = null;
            val_102 = val_51;
            val_51 = new System.ArgumentException();
            goto label_60;
            label_5:
            System.ArgumentException val_52 = null;
            val_102 = val_52;
            val_52 = new System.ArgumentException(message:  "Number of rounds must be even");
            label_60:
        }
    
    }

}
