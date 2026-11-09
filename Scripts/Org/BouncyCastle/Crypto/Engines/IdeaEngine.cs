using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class IdeaEngine : IBlockCipher
    {
        // Fields
        private const int BLOCK_SIZE = 8;
        private int[] workingKey;
        private static readonly int MASK;
        private static readonly int BASE;
        
        // Properties
        public virtual string AlgorithmName { get; }
        public virtual bool IsPartialBlockOkay { get; }
        
        // Methods
        public IdeaEngine()
        {
        
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            if(parameters != null)
            {
                    System.Byte[] val_1 = parameters.GetKey();
                System.Int32[] val_2 = val_1.ExpandKey(uKey:  val_1);
                this.workingKey = val_2.InvertKey(inKey:  val_2);
                return;
            }
            
            System.ArgumentException val_6 = new System.ArgumentException(message:  "invalid parameter passed to IDEA init - "("invalid parameter passed to IDEA init - ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)));
        }
        public virtual string get_AlgorithmName()
        {
            return "IDEA";
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
                this.IdeaFunc(workingKey:  this.workingKey, input:  input, inOff:  inOff, outBytes:  output, outOff:  outOff);
                return 8;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "IDEA engine not initialised");
        }
        public virtual void Reset()
        {
        
        }
        private int BytesToWord(byte[] input, int inOff)
        {
            int val_2 = input.Length;
            if(val_2 <= inOff)
            {
                    val_2 = input.Length;
            }
            
            byte val_2 = input[(long)inOff];
            return (int)input[(long)inOff + 1];
        }
        private void WordToBytes(int word, byte[] outBytes, int outOff)
        {
            outBytes[(long)outOff] = word >> 8;
            outBytes[(long)outOff + 1] = word;
        }
        private int Mul(int x, int y)
        {
            var val_3;
            var val_4;
            int val_2 = y;
            if(x == 0)
            {
                goto label_1;
            }
            
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            val_2 = val_2 * x;
            val_3 = null;
            val_3 = null;
            int val_3 = Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK;
            val_3 = val_3 & val_2;
            val_3 = val_3 - (val_2 >> 16);
            val_2 = () ? (val_3 + 1) : (val_3);
            goto label_8;
            label_1:
            val_3 = null;
            val_3 = null;
            val_4 = Org.BouncyCastle.Crypto.Engines.IdeaEngine.BASE - val_2;
            goto label_8;
            label_2:
            val_3 = null;
            val_3 = null;
            val_4 = Org.BouncyCastle.Crypto.Engines.IdeaEngine.BASE - x;
            label_8:
            val_3 = null;
            return (int)Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK & val_4;
        }
        private void IdeaFunc(int[] workingKey, byte[] input, int inOff, byte[] outBytes, int outOff)
        {
            int val_23;
            var val_24;
            var val_25;
            int val_26;
            var val_27;
            var val_28;
            var val_29;
            int val_30;
            int val_31;
            int val_1 = this.BytesToWord(input:  input, inOff:  inOff);
            val_23 = val_1;
            int val_3 = val_1.BytesToWord(input:  input, inOff:  inOff + 2);
            val_24 = val_3;
            int val_5 = val_3.BytesToWord(input:  input, inOff:  inOff + 4);
            val_25 = val_5;
            val_26 = val_5.BytesToWord(input:  input, inOff:  inOff + 6);
            val_27 = 0;
            val_28 = 0;
            goto label_1;
            label_12:
            val_29 = null;
            int val_26 = workingKey[4];
            val_29 = null;
            val_30 = workingKey.Length;
            val_26 = val_26 + val_24;
            if(2 < val_30)
            {
                    val_31 = Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK;
            }
            else
            {
                    val_31 = Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK;
                val_30 = workingKey.Length;
            }
            
            int val_27 = workingKey[8];
            val_26 = Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK & val_26;
            int val_9 = val_31 & (val_27 + val_25);
            int val_10 = Mul(x:  val_26, y:  workingKey[12]);
            int val_12 = val_10 ^ val_26;
            int val_13 = val_10.Mul(x:  val_9 ^ val_23, y:  workingKey[16]);
            val_27 = val_13 + val_12;
            val_28 = 6;
            val_12 = Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK & val_27;
            int val_14 = val_13.Mul(x:  val_12, y:  workingKey[20]);
            val_24 = val_14 ^ val_9;
            val_23 = val_14 ^ val_23;
            val_27 = 1;
            int val_31 = Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK;
            val_31 = val_31 & (val_14 + val_13);
            val_26 = val_31 ^ val_10;
            val_25 = val_31 ^ val_26;
            label_1:
            if(workingKey == null)
            {
                    val_29 = 0;
            }
            
            int val_16 = this.Mul(x:  val_23, y:  workingKey[24]);
            if(val_27 < 8)
            {
                goto label_12;
            }
            
            val_16.WordToBytes(word:  val_16, outBytes:  outBytes, outOff:  outOff);
            var val_17 = val_28 + 1;
            var val_18 = val_28 + 2;
            val_16.WordToBytes(word:  (workingKey[((long)(int)((val_28 + 1))) << 2]) + val_25, outBytes:  outBytes, outOff:  outOff + 2);
            var val_21 = val_28 + 3;
            val_16.WordToBytes(word:  (workingKey[((long)(int)((val_28 + 2))) << 2]) + val_24, outBytes:  outBytes, outOff:  outOff + 4);
            int val_24 = val_16.Mul(x:  val_26, y:  workingKey[((long)(int)((val_28 + 3))) << 2]);
            val_24.WordToBytes(word:  val_24, outBytes:  outBytes, outOff:  outOff + 6);
        }
        private int[] ExpandKey(byte[] uKey)
        {
            System.Array val_7;
            System.Array val_8;
            int val_9;
            int val_11;
            var val_12;
            val_7 = uKey;
            int[] val_1 = new int[52];
            if(val_7 == null)
            {
                    val_8 = 0;
            }
            
            if(uKey.Length <= 15)
            {
                    byte[] val_2 = new byte[16];
                val_8 = val_7;
                System.Array.Copy(sourceArray:  val_8, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  val_2.Length - uKey.Length, length:  uKey.Length);
                val_7 = val_2;
            }
            
            var val_14 = 0;
            var val_13 = 0;
            do
            {
                mem2[0] = val_8.BytesToWord(input:  val_2, inOff:  0);
                val_13 = val_13 + 1;
                val_14 = val_14 + 2;
            }
            while(val_13 != 8);
            
            var val_15 = 0;
            label_20:
            var val_5 = 8 & 7;
            if(val_5 <= 5)
            {
                goto label_7;
            }
            
            if(val_5 != 6)
            {
                goto label_8;
            }
            
            val_9 = val_1.Length;
            if((val_15 + 1) < val_9)
            {
                goto label_10;
            }
            
            val_9 = val_1.Length;
            goto label_10;
            label_7:
            val_11 = val_1.Length;
            if((val_15 + 1) >= val_11)
            {
                    val_11 = val_1.Length;
            }
            
            var val_8 = val_15 + 2;
            val_12 = null;
            goto label_18;
            label_8:
            val_9 = val_1.Length;
            if((val_15 - 7) >= val_9)
            {
                    val_9 = val_1.Length;
            }
            
            label_10:
            var val_10 = val_15 - 6;
            val_12 = null;
            val_12 = null;
            label_18:
            val_15 = val_15 + 1;
            mem2[0] = Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK & (W10 | 8736443);
            if(val_15 != 44)
            {
                goto label_20;
            }
            
            return (System.Int32[])val_1;
        }
        private int MulInv(int x)
        {
            var val_6;
            var val_7;
            var val_8;
            int val_9;
            val_6 = x;
            if(val_6 < 2)
            {
                    return (int)val_6;
            }
            
            val_7 = null;
            val_7 = null;
            val_8 = Org.BouncyCastle.Crypto.Engines.IdeaEngine.BASE / val_6;
            int val_1 = Org.BouncyCastle.Crypto.Engines.IdeaEngine.BASE - (val_8 * val_6);
            if(val_1 == 1)
            {
                goto label_4;
            }
            
            var val_5 = 1;
            label_10:
            int val_2 = val_6 / val_1;
            val_6 = val_6 - (val_2 * val_1);
            val_7 = null;
            val_9 = Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK;
            val_5 = val_9 & (val_5 + (val_2 * val_8));
            if(val_6 == 1)
            {
                goto label_7;
            }
            
            val_2 = val_1 / val_6;
            val_1 = val_1 - (val_2 * val_6);
            val_7 = null;
            val_9 = Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK;
            val_8 = val_9 & (val_8 + (val_2 * val_5));
            if(val_1 != 1)
            {
                goto label_10;
            }
            
            label_4:
            val_7 = null;
            var val_6 = 1;
            val_6 = val_6 - val_8;
            val_6 = Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK & val_6;
            return (int)val_6;
            label_7:
            val_6 = val_5;
            return (int)val_6;
        }
        private int AddInv(int x)
        {
            null = null;
            return (int)Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK & (-x);
        }
        private int[] InvertKey(int[] inKey)
        {
            var val_11;
            int val_12;
            var val_13;
            var val_14;
            var val_15;
            int val_16;
            int[] val_1 = new int[52];
            if(inKey == null)
            {
                    val_11 = 0;
            }
            
            int val_2 = this.MulInv(x:  inKey[0]);
            int val_3 = val_2.AddInv(x:  inKey[0]);
            int val_4 = val_3.AddInv(x:  inKey[1]);
            if(val_1 == null)
            {
                    val_11 = 0;
            }
            
            val_12 = val_1.Length;
            if(val_12 <= 51)
            {
                    val_12 = val_1.Length;
            }
            
            val_1[25] = val_4.MulInv(x:  inKey[1]);
            if(val_12 <= 50)
            {
                    val_12 = val_1.Length;
            }
            
            val_1[25] = val_4;
            if(val_12 <= 49)
            {
                    val_12 = val_1.Length;
            }
            
            val_1[24] = val_3;
            val_1[24] = val_2;
            val_13 = 1;
            val_14 = 9;
            val_15 = 42;
            goto label_11;
            label_24:
            int val_6 = this.MulInv(x:  inKey[36]);
            val_1[180] = val_6;
            val_1[176] = val_3;
            val_1[172] = val_4;
            val_13 = 2;
            val_14 = 15;
            val_15 = 36;
            val_1[168] = val_2;
            label_11:
            val_16 = inKey.Length;
            var val_8 = val_14 - 4;
            if((val_14 - 5) >= val_16)
            {
                    val_16 = inKey.Length;
            }
            
            var val_9 = val_15 + 5;
            val_1[((long)(int)((val_15 + 5))) << 2] = inKey[((long)(int)((val_14 - 4))) << 2];
            var val_10 = val_15 + 4;
            var val_11 = val_14 - 3;
            val_1[((long)(int)((val_15 + 4))) << 2] = inKey[((long)(int)((val_14 - 5))) << 2];
            var val_12 = val_14 - 2;
            int val_13 = val_6.MulInv(x:  inKey[((long)(int)((val_14 - 3))) << 2]);
            var val_14 = val_14 - 1;
            int val_15 = val_13.AddInv(x:  inKey[((long)(int)((val_14 - 2))) << 2]);
            int val_16 = val_15.AddInv(x:  inKey[((long)(int)((val_14 - 1))) << 2]);
            if(val_13 < 8)
            {
                goto label_24;
            }
            
            var val_18 = val_15 + 3;
            val_1[((long)(int)((val_15 + 3))) << 2] = val_16.MulInv(x:  inKey[60]);
            var val_19 = val_15 + 2;
            val_1[((long)(int)((val_15 + 2))) << 2] = val_16;
            var val_20 = val_15 + 1;
            val_1[((long)(int)((val_15 + 1))) << 2] = val_15;
            val_1[144] = val_13;
            return (System.Int32[])val_1;
        }
        private int[] GenerateWorkingKey(bool forEncryption, byte[] userKey)
        {
            System.Int32[] val_1 = this.ExpandKey(uKey:  userKey);
            if(forEncryption == false)
            {
                    return val_1.InvertKey(inKey:  val_1);
            }
            
            return val_1;
        }
        private static IdeaEngine()
        {
            Org.BouncyCastle.Crypto.Engines.IdeaEngine.MASK = 65535;
            Org.BouncyCastle.Crypto.Engines.IdeaEngine.BASE = 65537;
        }
    
    }

}
