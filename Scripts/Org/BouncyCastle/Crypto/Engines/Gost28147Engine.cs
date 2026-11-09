using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class Gost28147Engine : IBlockCipher
    {
        // Fields
        private const int BlockSize = 8;
        private int[] workingKey;
        private bool forEncryption;
        private byte[] S;
        private static readonly byte[] Sbox_Default;
        private static readonly byte[] ESbox_Test;
        private static readonly byte[] ESbox_A;
        private static readonly byte[] ESbox_B;
        private static readonly byte[] ESbox_C;
        private static readonly byte[] ESbox_D;
        private static readonly byte[] DSbox_Test;
        private static readonly byte[] DSbox_A;
        private static readonly System.Collections.IDictionary sBoxes;
        
        // Properties
        public virtual string AlgorithmName { get; }
        public virtual bool IsPartialBlockOkay { get; }
        
        // Methods
        private static Gost28147Engine()
        {
            byte[] val_1 = new byte[128] {4, 10, 9, 2, 13, 8, 0, 14, 6, 11, 1, 12, 7, 15, 5, 3, 14, 11, 4, 12, 6, 13, 15, 10, 2, 3, 8, 1, 0, 7, 5, 9, 5, 8, 1, 13, 10, 3, 4, 2, 14, 15, 12, 7, 6, 0, 9, 11, 7, 13, 10, 1, 0, 8, 9, 15, 14, 4, 6, 12, 11, 2, 5, 3, 6, 12, 7, 1, 5, 15, 13, 8, 4, 10, 9, 14, 0, 3, 11, 2, 4, 11, 10, 0, 7, 2, 1, 13, 3, 6, 8, 5, 9, 12, 15, 14, 13, 11, 4, 1, 3, 15, 5, 9, 0, 10, 14, 7, 6, 8, 2, 12, 1, 15, 13, 0, 5, 7, 10, 4, 9, 2, 3, 14, 6, 11, 8, 12};
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.Sbox_Default = val_1;
            byte[] val_2 = new byte[128] {4, 2, 15, 5, 9, 1, 0, 8, 14, 3, 11, 12, 13, 7, 10, 6, 12, 9, 15, 14, 8, 1, 3, 10, 2, 7, 4, 13, 6, 0, 11, 5, 13, 8, 14, 12, 7, 3, 9, 10, 1, 5, 2, 4, 6, 15, 0, 11, 14, 9, 11, 2, 5, 15, 7, 1, 0, 13, 12, 6, 10, 4, 3, 8, 3, 14, 5, 9, 6, 8, 0, 13, 10, 11, 7, 12, 2, 1, 15, 4, 8, 15, 6, 11, 1, 9, 12, 5, 13, 3, 7, 10, 0, 14, 2, 4, 9, 11, 12, 0, 3, 6, 7, 5, 4, 8, 14, 15, 1, 10, 2, 13, 12, 6, 5, 2, 11, 0, 9, 13, 3, 14, 7, 10, 15, 4, 1, 8};
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.ESbox_Test = val_2;
            byte[] val_3 = new byte[128] {9, 6, 3, 2, 8, 11, 1, 7, 10, 4, 14, 15, 12, 0, 13, 5, 3, 7, 14, 9, 8, 10, 15, 0, 5, 2, 6, 12, 11, 4, 13, 1, 14, 4, 6, 2, 11, 3, 13, 8, 12, 15, 5, 10, 0, 7, 1, 9, 14, 7, 10, 12, 13, 1, 3, 9, 0, 2, 11, 4, 15, 8, 5, 6, 11, 5, 1, 9, 8, 13, 15, 0, 14, 4, 2, 3, 12, 7, 10, 6, 3, 10, 13, 12, 1, 2, 0, 11, 7, 5, 9, 4, 8, 15, 14, 6, 1, 13, 2, 9, 7, 10, 6, 0, 8, 12, 4, 5, 15, 3, 11, 14, 11, 10, 15, 5, 0, 12, 14, 8, 6, 2, 3, 9, 1, 7, 13, 4};
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.ESbox_A = val_3;
            byte[] val_4 = new byte[128] {8, 4, 11, 1, 3, 5, 0, 9, 2, 14, 10, 12, 13, 6, 7, 15, 0, 1, 2, 10, 4, 13, 5, 12, 9, 7, 3, 15, 11, 8, 6, 14, 14, 12, 0, 10, 9, 2, 13, 11, 7, 5, 8, 15, 3, 6, 1, 4, 7, 5, 0, 13, 11, 6, 1, 2, 3, 10, 12, 15, 4, 14, 9, 8, 2, 7, 12, 15, 9, 5, 10, 11, 1, 4, 0, 13, 6, 8, 14, 3, 8, 3, 2, 6, 4, 13, 14, 11, 12, 1, 7, 15, 10, 0, 9, 5, 5, 2, 10, 11, 9, 1, 12, 3, 7, 4, 13, 0, 6, 15, 8, 14, 0, 4, 11, 14, 8, 3, 7, 1, 10, 2, 9, 6, 15, 13, 5, 12};
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.ESbox_B = val_4;
            byte[] val_5 = new byte[128] {1, 11, 12, 2, 9, 13, 0, 15, 4, 5, 8, 14, 10, 7, 6, 3, 0, 1, 7, 13, 11, 4, 5, 2, 8, 14, 15, 12, 9, 10, 6, 3, 8, 2, 5, 0, 4, 9, 15, 10, 3, 7, 12, 13, 6, 14, 1, 11, 3, 6, 0, 1, 5, 13, 10, 8, 11, 2, 9, 7, 14, 15, 12, 4, 8, 13, 11, 0, 4, 5, 1, 2, 9, 3, 12, 14, 6, 15, 10, 7, 12, 9, 11, 1, 8, 14, 2, 4, 7, 3, 6, 5, 10, 0, 15, 13, 10, 9, 6, 8, 13, 14, 2, 0, 15, 3, 5, 11, 4, 1, 12, 7, 7, 4, 0, 5, 10, 2, 15, 14, 12, 6, 1, 11, 13, 9, 3, 8};
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.ESbox_C = val_5;
            byte[] val_6 = new byte[128] {15, 12, 2, 10, 6, 4, 5, 0, 7, 9, 14, 13, 1, 11, 8, 3, 11, 6, 3, 4, 12, 15, 14, 2, 7, 13, 8, 0, 5, 10, 9, 1, 1, 12, 11, 0, 15, 14, 6, 5, 10, 13, 4, 8, 9, 3, 7, 2, 1, 5, 14, 12, 10, 7, 0, 13, 6, 2, 11, 4, 9, 3, 15, 8, 0, 12, 8, 9, 13, 2, 10, 11, 7, 3, 6, 5, 4, 14, 15, 1, 8, 0, 15, 3, 2, 5, 14, 11, 1, 10, 4, 7, 12, 9, 13, 6, 3, 0, 6, 15, 1, 14, 9, 2, 13, 8, 12, 4, 11, 10, 5, 7, 1, 10, 6, 8, 15, 11, 0, 4, 12, 3, 5, 9, 7, 13, 2, 14};
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.ESbox_D = val_6;
            byte[] val_7 = new byte[128] {4, 10, 9, 2, 13, 8, 0, 14, 6, 11, 1, 12, 7, 15, 5, 3, 14, 11, 4, 12, 6, 13, 15, 10, 2, 3, 8, 1, 0, 7, 5, 9, 5, 8, 1, 13, 10, 3, 4, 2, 14, 15, 12, 7, 6, 0, 9, 11, 7, 13, 10, 1, 0, 8, 9, 15, 14, 4, 6, 12, 11, 2, 5, 3, 6, 12, 7, 1, 5, 15, 13, 8, 4, 10, 9, 14, 0, 3, 11, 2, 4, 11, 10, 0, 7, 2, 1, 13, 3, 6, 8, 5, 9, 12, 15, 14, 13, 11, 4, 1, 3, 15, 5, 9, 0, 10, 14, 7, 6, 8, 2, 12, 1, 15, 13, 0, 5, 7, 10, 4, 9, 2, 3, 14, 6, 11, 8, 12};
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.DSbox_Test = val_7;
            byte[] val_8 = new byte[128] {10, 4, 5, 6, 8, 1, 3, 7, 13, 12, 14, 0, 9, 2, 11, 15, 5, 15, 4, 0, 2, 13, 11, 9, 1, 7, 6, 3, 12, 14, 10, 8, 7, 15, 12, 14, 9, 4, 1, 0, 3, 11, 5, 2, 6, 10, 8, 13, 4, 10, 7, 12, 0, 15, 2, 8, 14, 1, 6, 5, 13, 11, 9, 3, 7, 6, 4, 11, 9, 12, 2, 10, 1, 8, 0, 14, 15, 13, 3, 5, 7, 6, 2, 4, 13, 9, 15, 0, 10, 1, 5, 11, 8, 14, 12, 3, 13, 14, 4, 1, 7, 0, 5, 10, 3, 12, 8, 15, 6, 2, 9, 11, 1, 3, 10, 9, 5, 11, 4, 15, 8, 6, 7, 14, 13, 0, 2, 12};
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.DSbox_A = val_8;
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.sBoxes = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox(sBoxName:  "Default", sBox:  val_1);
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox(sBoxName:  "E-TEST", sBox:  val_2);
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox(sBoxName:  "E-A", sBox:  val_3);
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox(sBoxName:  "E-B", sBox:  val_4);
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox(sBoxName:  "E-C", sBox:  val_5);
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox(sBoxName:  "E-D", sBox:  val_6);
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox(sBoxName:  "D-TEST", sBox:  val_7);
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox(sBoxName:  "D-A", sBox:  val_8);
        }
        private static void AddSBox(string sBoxName, byte[] sBox)
        {
            var val_3 = null;
            var val_3 = 0;
            val_3 = val_3 + 1;
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.sBoxes.Add(key:  Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  sBoxName), value:  sBox);
        }
        public Gost28147Engine()
        {
            null = null;
            this.S = Org.BouncyCastle.Crypto.Engines.Gost28147Engine.Sbox_Default;
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            if(parameters == null)
            {
                    return;
            }
            
            this.workingKey = this.generateWorkingKey(forEncryption:  forEncryption, userKey:  parameters.GetKey());
            return;
            label_21:
            System.ArgumentException val_15 = new System.ArgumentException(message:  "invalid S-box passed to GOST28147 init");
            goto label_21;
        }
        public virtual string get_AlgorithmName()
        {
            return "Gost28147";
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
                this.Gost28147Func(workingKey:  this.workingKey, inBytes:  input, inOff:  inOff, outBytes:  output, outOff:  outOff);
                return 8;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Gost28147 engine not initialised");
        }
        public virtual void Reset()
        {
        
        }
        private int[] generateWorkingKey(bool forEncryption, byte[] userKey)
        {
            this.forEncryption = forEncryption;
            if(userKey.Length == 32)
            {
                    int[] val_2 = new int[8];
                var val_6 = 0;
                var val_5 = 0;
                do
            {
                val_5 = val_5 + 1;
                mem2[0] = Org.BouncyCastle.Crypto.Engines.Gost28147Engine.bytesToint(inBytes:  userKey, inOff:  0);
                val_6 = val_6 + 4;
            }
            while(val_5 != 8);
            
                return (System.Int32[])val_2;
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "Key length invalid. Key needs to be 32 byte - 256 bit!!!");
        }
        private int Gost28147_mainStep(int n1, int key)
        {
            byte val_3 = (this.S[(key + n1) & 15]) + (this.S[16] << 4);
            val_3 = val_3 + (this.S[32] << 8);
            val_3 = val_3 + (this.S[48] << 12);
            byte val_12 = this.S[112];
            val_3 = val_3 + (this.S[64] << 16);
            val_3 = val_3 + (this.S[80] << 20);
            val_3 = val_3 + (this.S[96] << 24);
            val_12 = val_3 + (val_12 << 28);
            return (int)val_12 >> 21;
        }
        private void Gost28147Func(int[] workingKey, byte[] inBytes, int inOff, byte[] outBytes, int outOff)
        {
            int val_10;
            int val_11;
            var val_12;
            System.Int32[] val_21 = workingKey;
            int val_12 = Org.BouncyCastle.Crypto.Engines.Gost28147Engine.bytesToint(inBytes:  inBytes, inOff:  inOff);
            int val_3 = Org.BouncyCastle.Crypto.Engines.Gost28147Engine.bytesToint(inBytes:  inBytes, inOff:  inOff + 4);
            if(this.forEncryption == false)
            {
                goto label_3;
            }
            
            var val_13 = 0;
            do
            {
                var val_11 = 0;
                do
            {
                val_11 = val_11 + 1;
                val_12 = (this.Gost28147_mainStep(n1:  val_12, key:  1118264816)) ^ val_3;
            }
            while(val_11 != 8);
            
                val_13 = val_13 + 1;
            }
            while(val_13 != 3);
            
            var val_15 = 15;
            do
            {
                val_10 = val_12;
                val_11 = (this.Gost28147_mainStep(n1:  val_10, key:  val_21[3])) ^ val_12;
                val_15 = val_15 - 1;
                val_12 = val_10;
            }
            while((val_15 - 8) >= 2);
            
            goto label_20;
            label_3:
            var val_16 = 0;
            do
            {
                val_16 = val_16 + 1;
                val_12 = (this.Gost28147_mainStep(n1:  val_12, key:  1118264816)) ^ val_3;
                val_12 = val_12;
            }
            while(val_16 != 8);
            
            var val_19 = 0;
            do
            {
                var val_18 = 15;
                val_10 = val_12;
                do
            {
                if(val_19 == 2)
            {
                    if(val_18 == 8)
            {
                goto label_15;
            }
            
            }
            
                val_12 = val_18 - 8;
                val_11 = (this.Gost28147_mainStep(n1:  val_12, key:  val_21[3])) ^ val_10;
                val_18 = val_18 - 1;
            }
            while(val_12 > 0);
            
                val_19 = val_19 + 1;
                val_10 = val_12;
            }
            while(val_19 != 3);
            
            goto label_20;
            label_15:
            val_11 = val_12;
            label_20:
            val_21 = (this.Gost28147_mainStep(n1:  val_11, key:  val_21[0])) ^ val_10;
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.intTobytes(num:  val_11, outBytes:  outBytes, outOff:  outOff);
            Org.BouncyCastle.Crypto.Engines.Gost28147Engine.intTobytes(num:  val_21, outBytes:  outBytes, outOff:  outOff + 4);
        }
        private static int bytesToint(byte[] inBytes, int inOff)
        {
            int val_5 = inBytes.Length;
            int val_1 = inOff + 3;
            if(val_1 >= val_5)
            {
                    val_5 = inBytes.Length;
            }
            
            int val_2 = inOff + 2;
            if(val_2 >= val_5)
            {
                    val_5 = inBytes.Length;
            }
            
            byte val_6 = inBytes[(long)val_2];
            int val_3 = inOff + 1;
            if(val_3 >= val_5)
            {
                    val_5 = inBytes.Length;
            }
            
            byte val_7 = inBytes[(long)val_3];
            inBytes = (inBytes[(long)val_1] << 24) | inBytes[(long)inOff];
            return (int)inBytes;
        }
        private static void intTobytes(int num, byte[] outBytes, int outOff)
        {
            outBytes[(long)outOff + 3] = num >> 24;
            outBytes[(long)outOff + 2] = num >> 16;
            outBytes[(long)outOff + 1] = num >> 8;
            outBytes[(long)outOff] = num;
        }
        public static byte[] GetSBox(string sBoxName)
        {
            var val_5 = null;
            var val_6 = 0;
            val_6 = val_6 + 1;
            object val_3 = Org.BouncyCastle.Crypto.Engines.Gost28147Engine.sBoxes.Item[Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  sBoxName)];
            if(val_3 != null)
            {
                    if(val_3 != null)
            {
                    return Org.BouncyCastle.Utilities.Arrays.Clone(data:  val_3);
            }
            
            }
            
            System.ArgumentException val_5 = new System.ArgumentException(message:  "Unknown S-Box - possible types: \"Default\", \"E-Test\", \"E-A\", \"E-B\", \"E-C\", \"E-D\", \"D-Test\", \"D-A\".");
        }
    
    }

}
