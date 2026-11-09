using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class DesEngine : IBlockCipher
    {
        // Fields
        internal const int BLOCK_SIZE = 8;
        private int[] workingKey;
        private static readonly short[] bytebit;
        private static readonly int[] bigbyte;
        private static readonly byte[] pc1;
        private static readonly byte[] totrot;
        private static readonly byte[] pc2;
        private static readonly uint[] SP1;
        private static readonly uint[] SP2;
        private static readonly uint[] SP3;
        private static readonly uint[] SP4;
        private static readonly uint[] SP5;
        private static readonly uint[] SP6;
        private static readonly uint[] SP7;
        private static readonly uint[] SP8;
        
        // Properties
        public virtual string AlgorithmName { get; }
        public virtual bool IsPartialBlockOkay { get; }
        
        // Methods
        public virtual int[] GetWorkingKey()
        {
            return (System.Int32[])this.workingKey;
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            if(parameters != null)
            {
                    this.workingKey = Org.BouncyCastle.Crypto.Engines.DesEngine.GenerateWorkingKey(encrypting:  forEncryption, key:  parameters.GetKey());
                return;
            }
            
            System.ArgumentException val_6 = new System.ArgumentException(message:  "invalid parameter passed to DES init - "("invalid parameter passed to DES init - ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)));
        }
        public virtual string get_AlgorithmName()
        {
            return "DES";
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
                Org.BouncyCastle.Crypto.Engines.DesEngine.DesFunc(wKey:  this.workingKey, input:  input, inOff:  inOff, outBytes:  output, outOff:  outOff);
                return 8;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "DES engine not initialised");
        }
        public virtual void Reset()
        {
        
        }
        protected static int[] GenerateWorkingKey(bool encrypting, byte[] key)
        {
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            bool val_24;
            int val_25;
            var val_26;
            var val_27;
            var val_28;
            System.Byte[] val_29;
            var val_30;
            int val_31;
            int[] val_1 = new int[32];
            bool[] val_2 = new bool[56];
            bool[] val_3 = new bool[56];
            var val_26 = 0;
            do
            {
                val_20 = null;
                val_20 = null;
                var val_25 = Org.BouncyCastle.Crypto.Engines.DesEngine.pc1.Length + 32;
                val_25 = val_25 & 7;
                System.Int16[] val_5 = Org.BouncyCastle.Crypto.Engines.DesEngine.bytebit + (((Org.BouncyCastle.Crypto.Engines.DesEngine.pc1.Length + 32 & 7)) << 1);
                mem2[0] = (((Org.BouncyCastle.Crypto.Engines.DesEngine.bytebit + ((Org.BouncyCastle.Crypto.Engines.DesEngine.pc1.Length + 32 & 7)) << 1) + 32) != (key[val_25 >> 3])) ? 1 : 0;
                val_26 = val_26 + 1;
            }
            while(val_26 != 56);
            
            var val_38 = 0;
            System.Boolean[] val_27 = val_3[32];
            System.Boolean[] val_28 = val_3[60];
            label_65:
            var val_29 = 15;
            val_29 = val_29 - val_38;
            val_1[4] = 0;
            var val_31 = 0;
            val_1[((long)(int)((encrypting != true ? 0 : (15 - 0) << 1))) << 2] = 0;
            goto label_27;
            label_23:
            val_21 = (long)(long)((encrypting != true) ? (val_38) : (val_29)) << 1;
            if(((long)((encrypting != true) ? (val_38) : (val_29)) << 1) >= val_2.Length)
            {
                goto label_16;
            }
            
            goto label_24;
            label_27:
            val_22 = null;
            val_22 = null;
            if((val_31 + (Org.BouncyCastle.Crypto.Engines.DesEngine.totrot.Length + 32)) <= 27)
            {
                goto label_23;
            }
            
            var val_10 = val_31 + (Org.BouncyCastle.Crypto.Engines.DesEngine.totrot.Length + 32);
            val_10 = val_10 - 28;
            val_21 = (long)val_10;
            if(val_10 < val_2.Length)
            {
                goto label_24;
            }
            
            label_16:
            label_24:
            mem2[0] = val_2[val_21];
            val_31 = val_31 + 1;
            if(val_31 != 28)
            {
                goto label_27;
            }
            
            var val_32 = 0;
            do
            {
                val_23 = null;
                val_23 = null;
                var val_12 = (val_32 + (Org.BouncyCastle.Crypto.Engines.DesEngine.totrot.Length + 32)) + 28;
                var val_13 = val_32 + 28;
                if(val_12 > 55)
            {
                    val_24 = val_2[(long)val_32 + (Org.BouncyCastle.Crypto.Engines.DesEngine.totrot.Length + 32)];
                val_25 = val_3.Length;
            }
            else
            {
                    val_25 = val_3.Length;
                val_24 = val_2[(long)val_12];
            }
            
                mem2[0] = val_24;
                val_32 = val_32 + 1;
            }
            while(val_32 != 28);
            
            var val_37 = 0;
            do
            {
                val_26 = null;
                val_26 = null;
                if((val_3[Org.BouncyCastle.Crypto.Engines.DesEngine.pc2.Length + 32]) != false)
            {
                    val_27 = null;
                val_27 = null;
                var val_34 = Org.BouncyCastle.Crypto.Engines.DesEngine.bigbyte.Length + 32;
                val_34 = val_34 | (val_1[((long)(int)((encrypting != true ? 0 : (15 - 0) << 1))) << 2] + 32);
                mem2[0] = val_34;
            }
            
                val_28 = null;
                val_28 = null;
                val_29 = Org.BouncyCastle.Crypto.Engines.DesEngine.pc2;
                var val_15 = val_37 + 24;
                if((val_3[Org.BouncyCastle.Crypto.Engines.DesEngine.pc2.Length + 56]) != false)
            {
                    val_30 = null;
                val_29 = mem[val_1[0x4] + 32];
                val_29 = val_1[0x4] + 32;
                val_30 = null;
                var val_36 = Org.BouncyCastle.Crypto.Engines.DesEngine.bigbyte.Length + 32;
                val_36 = val_36 | val_29;
                mem2[0] = val_36;
            }
            
                val_37 = val_37 + 1;
            }
            while(val_37 != 24);
            
            val_38 = val_38 + 1;
            if(val_38 != 16)
            {
                goto label_65;
            }
            
            do
            {
                val_31 = val_1.Length;
                if(0 >= val_31)
            {
                    val_31 = val_1.Length;
            }
            
                int val_39 = val_1[0];
                var val_16 = 0 + 1;
                if(val_16 >= val_31)
            {
                    val_31 = val_1.Length;
            }
            
                int val_40 = val_1[0];
                int val_17 = val_39 << 10;
                int val_18 = val_39 >> 18;
                val_17 = val_17 & 4128768;
                int val_19 = val_40 >> 10;
                val_19 = val_19 & 16128;
                val_16 = val_16 - 1;
                val_1[0] = val_17 | val_19;
                int val_21 = val_39 << 12;
                val_21 = val_21 & 1056964608;
                int val_22 = val_40 >> 4;
                val_22 = val_22 & 16128;
                var val_23 = val_16 + 1;
                val_39 = val_21 | val_22;
                val_23 = val_23 + 1;
                val_1[0] = val_39;
            }
            while(val_23 != 32);
            
            return (System.Int32[])val_1;
        }
        internal static void DesFunc(int[] wKey, byte[] input, int inOff, byte[] outBytes, int outOff)
        {
            var val_38;
            uint val_1 = Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  input, off:  inOff);
            uint val_3 = Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  input, off:  inOff + 4);
            uint val_4 = val_3 ^ (val_1 >> 4);
            val_4 = val_4 & 252645135;
            uint val_5 = val_4 ^ val_3;
            val_4 = val_1 ^ (val_4 << 4);
            uint val_6 = val_5 & 65535;
            val_6 = val_6 ^ (val_4 >> 16);
            val_5 = val_6 ^ val_5;
            val_4 = val_4 ^ (val_6 << 16);
            val_6 = val_4 ^ (val_5 >> 2);
            val_6 = val_6 & 858993459;
            val_4 = val_6 ^ val_4;
            val_5 = val_5 ^ (val_6 << 2);
            val_6 = val_4 ^ (val_5 >> 8);
            val_6 = val_6 & 16711935;
            val_4 = val_6 ^ val_4;
            val_5 = val_5 ^ (val_6 << 8);
            val_6 = val_4 ^ (val_5 << 1);
            val_6 = val_6 & 2863311530;
            val_4 = val_6 ^ val_4;
            val_4 = val_4 >> 31;
            var val_43 = 0;
            uint val_7 = val_6 ^ (((((((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 65535) ^ ((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4)) >> 16) ^ (((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3)) ^ (((((val_1 ^ (((val_3 ) << (32-31)) | ((((((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 65535) ^ ((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4)) >> 16) ^ (((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3)) ^ (((((val_1 ^ (((val_3 ) << 31));
            do
            {
                val_38 = null;
                uint val_8 = val_7 >> 4;
                val_38 = null;
                val_8 = 1152921505725111792 ^ val_8 & 63;
                System.UInt32[] val_10 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP7 + ((((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 65535) ^ ((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135))) << 2);
                System.UInt32[] val_11 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + (((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 65535) ^ ((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) >>8) & 0x3F)) << 2);
                System.UInt32[] val_12 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP3 + (((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 65535) ^ ((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) >>16) & 0x3F)) << 2);
                System.UInt32[] val_13 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP1 + (((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 65535) ^ ((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) >>24) & 0x3F)) << 2);
                var val_14 = val_43 + 1;
                val_7 = 1152921505725111792 ^ val_7 & 63;
                System.UInt32[] val_16 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP8 + ((((1152921505725111792 ^ (((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 65535) ^ ((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) ) << 2);
                var val_17 = ((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) &  + 32) | ((Org.BouncyCastle.Crypto.Engines.DesEngine.SP7 + (((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 65535)  + 32);
                val_17 = val_17 | ((Org.BouncyCastle.Crypto.Engines.DesEngine.SP3 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) &  + 32);
                System.UInt32[] val_18 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP6 + (((uint)(((1152921505725111792 ^ (((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 65535) ^ ((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) <>>8) & 0x3F)) << 2);
                val_17 = val_17 | ((Org.BouncyCastle.Crypto.Engines.DesEngine.SP1 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) &  + 32);
                val_17 = val_17 | ((Org.BouncyCastle.Crypto.Engines.DesEngine.SP8 + (((1152921505725111792 ^ (((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 65535) ^ + 32);
                System.UInt32[] val_19 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP4 + (((uint)(((1152921505725111792 ^ (((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 65535) ^ ((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) <>>16) & 0x3F)) << 2);
                val_17 = val_17 | ((Org.BouncyCastle.Crypto.Engines.DesEngine.SP6 + ((uint)(((1152921505725111792 ^ (((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 6 + 32);
                var val_20 = val_17 | ((Org.BouncyCastle.Crypto.Engines.DesEngine.SP4 + ((uint)(((1152921505725111792 ^ (((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 6 + 32);
                System.UInt32[] val_21 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP2 + (((uint)(((1152921505725111792 ^ (((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 65535) ^ ((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) <>>24) & 0x3F)) << 2);
                var val_41 = (Org.BouncyCastle.Crypto.Engines.DesEngine.SP2 + ((uint)(((1152921505725111792 ^ (((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) >> 4) & 252645135) ^ val_3) & 6 + 32;
                uint val_42 = val_4;
                var val_22 = val_43 + 2;
                val_41 = val_20 | val_41;
                val_42 = val_41 ^ val_42;
                val_20 = val_42 >> 4;
                val_20 = 1152921505725111792 ^ val_20;
                System.Int32[] val_23 = val_20 & 63;
                System.UInt32[] val_24 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP7 + ((((1152921505725111792 ^ ((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_) << 2);
                System.UInt32[] val_25 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + (((uint)(((1152921505725111792 ^ ((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1>>8) & 0x3F)) << 2);
                System.UInt32[] val_26 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP3 + (((uint)(((1152921505725111792 ^ ((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1>>16) & 0x3F)) << 2);
                System.UInt32[] val_27 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP1 + (((uint)(((1152921505725111792 ^ ((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1>>24) & 0x3F)) << 2);
                var val_28 = val_43 + 3;
                System.Int32[] val_30 = 1152921505725111792 ^ val_42 & 63;
                System.UInt32[] val_31 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP8 + ((((1152921505725111792 ^ (((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1) << 2);
                var val_32 = ((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3  + 32) | ((Org.BouncyCastle.Crypto.Engines.DesEngine.SP7 + (((1152921505725111792 ^ ((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_ + 32);
                val_32 = val_32 | ((Org.BouncyCastle.Crypto.Engines.DesEngine.SP3 + ((uint)(((1152921505725111792 ^ ((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3  + 32);
                System.UInt32[] val_33 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP6 + (((uint)(((1152921505725111792 ^ (((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1)>>8) & 0x3F)) << 2);
                val_32 = val_32 | ((Org.BouncyCastle.Crypto.Engines.DesEngine.SP1 + ((uint)(((1152921505725111792 ^ ((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3  + 32);
                val_32 = val_32 | ((Org.BouncyCastle.Crypto.Engines.DesEngine.SP8 + (((1152921505725111792 ^ (((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1 + 32);
                System.UInt32[] val_34 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP4 + (((uint)(((1152921505725111792 ^ (((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1)>>16) & 0x3F)) << 2);
                val_32 = val_32 | ((Org.BouncyCastle.Crypto.Engines.DesEngine.SP6 + ((uint)(((1152921505725111792 ^ (((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ + 32);
                uint val_45 = val_7;
                System.UInt32[] val_36 = Org.BouncyCastle.Crypto.Engines.DesEngine.SP2 + (((uint)(((1152921505725111792 ^ (((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ (val_1) >> 4) & 252645135)) << 4) ^ ((((((val_3 ^ (val_1)>>24) & 0x3F)) << 2);
                var val_44 = (Org.BouncyCastle.Crypto.Engines.DesEngine.SP2 + ((uint)(((1152921505725111792 ^ (((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ + 32;
                val_43 = val_43 + 4;
                val_44 = (val_32 | ((Org.BouncyCastle.Crypto.Engines.DesEngine.SP4 + ((uint)(((1152921505725111792 ^ (((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ (((val_3 ^ + 32)) | val_44;
                val_45 = val_44 ^ val_45;
            }
            while(val_43 != 32);
            
            uint val_47 = val_42;
            var val_46 = -1431655766;
            uint val_37 = val_47 ^ ((((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ () << (32-1)) | (((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ () << 1));
            val_37 = val_37 & val_46;
            val_46 = val_37 ^ val_47;
            val_37 = val_37 ^ ((((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ () << (32-1)) | (((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 + ((uint)(((1152921505725111792 ^ ((((((((((((val_1 ^ () << 1));
            val_47 = val_37 ^ (val_46 >> 8);
            val_47 = val_47 & 16711935;
            val_37 = val_47 ^ val_37;
            val_46 = val_46 ^ (val_47 << 8);
            val_47 = val_37 ^ (val_46 >> 2);
            val_47 = val_47 & 858993459;
            val_46 = val_46 ^ (val_47 << 2);
            val_37 = val_47 ^ val_37;
            val_47 = val_46 & 65535;
            val_47 = val_47 ^ (val_37 >> 16);
            val_46 = val_47 ^ val_46;
            val_37 = val_37 ^ (val_47 << 16);
            val_47 = val_46 ^ (val_37 >> 4);
            val_47 = val_47 & 252645135;
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  val_37 ^ (val_47 << 4), bs:  outBytes, off:  outOff);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  val_47 ^ val_46, bs:  outBytes, off:  outOff + 4);
        }
        public DesEngine()
        {
        
        }
        private static DesEngine()
        {
            Org.BouncyCastle.Crypto.Engines.DesEngine.bytebit = new short[8] {128, 64, 32, 16, 8, 4, 2, 1};
            Org.BouncyCastle.Crypto.Engines.DesEngine.bigbyte = new int[24] {8388608, 4194304, 2097152, 1048576, 524288, 262144, 131072, 65536, 32768, 16384, 8192, 4096, 2048, 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1};
            Org.BouncyCastle.Crypto.Engines.DesEngine.pc1 = new byte[56] {56, 48, 40, 32, 24, 16, 8, 0, 57, 49, 41, 33, 25, 17, 9, 1, 58, 50, 42, 34, 26, 18, 10, 2, 59, 51, 43, 35, 62, 54, 46, 38, 30, 22, 14, 6, 61, 53, 45, 37, 29, 21, 13, 5, 60, 52, 44, 36, 28, 20, 12, 4, 27, 19, 11, 3};
            Org.BouncyCastle.Crypto.Engines.DesEngine.totrot = new byte[16] {1, 2, 4, 6, 8, 10, 12, 14, 15, 17, 19, 21, 23, 25, 27, 28};
            Org.BouncyCastle.Crypto.Engines.DesEngine.pc2 = new byte[48] {13, 16, 10, 23, 0, 4, 2, 27, 14, 5, 20, 9, 22, 18, 11, 3, 25, 7, 15, 6, 26, 19, 12, 1, 40, 51, 30, 36, 46, 54, 29, 39, 50, 44, 32, 47, 43, 48, 38, 55, 33, 52, 45, 41, 49, 35, 28, 31};
            Org.BouncyCastle.Crypto.Engines.DesEngine.SP1 = new uint[64] {16843776, 0, 65536, 16843780, 16842756, 66564, 4, 65536, 1024, 16843776, 16843780, 1024, 16778244, 16842756, 16777216, 4, 1028, 16778240, 16778240, 66560, 66560, 16842752, 16842752, 16778244, 65540, 16777220, 16777220, 65540, 0, 1028, 66564, 16777216, 65536, 16843780, 4, 16842752, 16843776, 16777216, 16777216, 1024, 16842756, 65536, 66560, 16777220, 1024, 4, 16778244, 66564, 16843780, 65540, 16842752, 16778244, 16777220, 1028, 66564, 16843776, 1028, 16778240, 16778240, 0, 65540, 66560, 0, 16842756};
            Org.BouncyCastle.Crypto.Engines.DesEngine.SP2 = new uint[64] {-2146402272, -2147450880, 32768, 1081376, 1048576, 32, -2146435040, -2147450848, -2147483616, -2146402272, -2146402304, -2147483648, -2147450880, 1048576, 32, -2146435040, 1081344, 1048608, -2147450848, 0, -2147483648, 32768, 1081376, -2146435072, 1048608, -2147483616, 0, 1081344, 32800, -2146402304, -2146435072, 32800, 0, 1081376, -2146435040, 1048576, -2147450848, -2146435072, -2146402304, 32768, -2146435072, -2147450880, 32, -2146402272, 1081376, 32, 32768, -2147483648, 32800, -2146402304, 1048576, -2147483616, 1048608, -2147450848, -2147483616, 1048608, 1081344, 0, -2147450880, 32800, -2147483648, -2146435040, -2146402272, 1081344};
            Org.BouncyCastle.Crypto.Engines.DesEngine.SP3 = new uint[64] {520, 134349312, 0, 134348808, 134218240, 0, 131592, 134218240, 131080, 134217736, 134217736, 131072, 134349320, 131080, 134348800, 520, 134217728, 8, 134349312, 512, 131584, 134348800, 134348808, 131592, 134218248, 131584, 131072, 134218248, 8, 134349320, 512, 134217728, 134349312, 134217728, 131080, 520, 131072, 134349312, 134218240, 0, 512, 131080, 134349320, 134218240, 134217736, 512, 0, 134348808, 134218248, 131072, 134217728, 134349320, 8, 131592, 131584, 134217736, 134348800, 134218248, 520, 134348800, 131592, 8, 134348808, 131584};
            Org.BouncyCastle.Crypto.Engines.DesEngine.SP4 = new uint[64] {8396801, 8321, 8321, 128, 8396928, 8388737, 8388609, 8193, 0, 8396800, 8396800, 8396929, 129, 0, 8388736, 8388609, 1, 8192, 8388608, 8396801, 128, 8388608, 8193, 8320, 8388737, 1, 8320, 8388736, 8192, 8396928, 8396929, 129, 8388736, 8388609, 8396800, 8396929, 129, 0, 0, 8396800, 8320, 8388736, 8388737, 1, 8396801, 8321, 8321, 128, 8396929, 129, 1, 8192, 8388609, 8193, 8396928, 8388737, 8193, 8320, 8388608, 8396801, 128, 8388608, 8192, 8396928};
            Org.BouncyCastle.Crypto.Engines.DesEngine.SP5 = new uint[64] {256, 34078976, 34078720, 1107296512, 524288, 256, 1073741824, 34078720, 1074266368, 524288, 33554688, 1074266368, 1107296512, 1107820544, 524544, 1073741824, 33554432, 1074266112, 1074266112, 0, 1073742080, 1107820800, 1107820800, 33554688, 1107820544, 1073742080, 0, 1107296256, 34078976, 33554432, 1107296256, 524544, 524288, 1107296512, 256, 33554432, 1073741824, 34078720, 1107296512, 1074266368, 33554688, 1073741824, 1107820544, 34078976, 1074266368, 256, 33554432, 1107820544, 1107820800, 524544, 1107296256, 1107820800, 34078720, 0, 1074266112, 1107296256, 524544, 33554688, 1073742080, 524288, 0, 1074266112, 34078976, 1073742080};
            Org.BouncyCastle.Crypto.Engines.DesEngine.SP6 = new uint[64] {536870928, 541065216, 16384, 541081616, 541065216, 16, 541081616, 4194304, 536887296, 4210704, 4194304, 536870928, 4194320, 536887296, 536870912, 16400, 0, 4194320, 536887312, 16384, 4210688, 536887312, 16, 541065232, 541065232, 0, 4210704, 541081600, 16400, 4210688, 541081600, 536870912, 536887296, 16, 541065232, 4210688, 541081616, 4194304, 16400, 536870928, 4194304, 536887296, 536870912, 16400, 536870928, 541081616, 4210688, 541065216, 4210704, 541081600, 0, 541065232, 16, 16384, 541065216, 4210704, 16384, 4194320, 536887312, 0, 541081600, 536870912, 4194320, 536887312};
            Org.BouncyCastle.Crypto.Engines.DesEngine.SP7 = new uint[64] {2097152, 69206018, 67110914, 0, 2048, 67110914, 2099202, 69208064, 69208066, 2097152, 0, 67108866, 2, 67108864, 69206018, 2050, 67110912, 2099202, 2097154, 67110912, 67108866, 69206016, 69208064, 2097154, 69206016, 2048, 2050, 69208066, 2099200, 2, 67108864, 2099200, 67108864, 2099200, 2097152, 67110914, 67110914, 69206018, 69206018, 2, 2097154, 67108864, 67110912, 2097152, 69208064, 2050, 2099202, 69208064, 2050, 67108866, 69208066, 69206016, 2099200, 0, 2, 69208066, 0, 2099202, 69206016, 2048, 67108866, 67110912, 2048, 2097154};
            Org.BouncyCastle.Crypto.Engines.DesEngine.SP8 = new uint[64] {268439616, 4096, 262144, 268701760, 268435456, 268439616, 64, 268435456, 262208, 268697600, 268701760, 266240, 268701696, 266304, 4096, 64, 268697600, 268435520, 268439552, 4160, 266240, 262208, 268697664, 268701696, 4160, 0, 0, 268697664, 268435520, 268439552, 266304, 262144, 266304, 262144, 268701696, 4096, 64, 268697664, 4096, 266304, 268439552, 64, 268435520, 268697600, 268697664, 268435456, 262144, 268439616, 0, 268701760, 262208, 268435520, 268697600, 268439552, 268439616, 0, 268701760, 266240, 266240, 4160, 4160, 262208, 268435456, 268701696};
        }
    
    }

}
