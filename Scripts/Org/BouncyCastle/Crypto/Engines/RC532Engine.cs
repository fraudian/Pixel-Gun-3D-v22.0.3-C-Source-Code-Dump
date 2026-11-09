using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class RC532Engine : IBlockCipher
    {
        // Fields
        private int _noRounds;
        private int[] _S;
        private static readonly int P32;
        private static readonly int Q32;
        private bool forEncryption;
        
        // Properties
        public virtual string AlgorithmName { get; }
        public virtual bool IsPartialBlockOkay { get; }
        
        // Methods
        public RC532Engine()
        {
            this._noRounds = 12;
        }
        public virtual string get_AlgorithmName()
        {
            return "RC5-32";
        }
        public virtual bool get_IsPartialBlockOkay()
        {
            return false;
        }
        public virtual int GetBlockSize()
        {
            return 8;
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            object val_13;
            var val_14;
            val_13 = parameters;
            if(((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) & 1) == 0)
            {
                goto label_4;
            }
            
            this._noRounds = 0.Rounds;
            goto label_13;
            label_4:
            if(((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) & 1) == 0)
            {
                goto label_12;
            }
            
            label_13:
            val_13 = 0;
            this.SetKey(key:  val_13.GetKey());
            this.forEncryption = forEncryption;
            return;
            label_12:
            val_14 = new System.ArgumentException(message:  "invalid parameter passed to RC532 init - "("invalid parameter passed to RC532 init - ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_13)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_13)));
        }
        public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
        {
            if(this.forEncryption != false)
            {
                    int val_1 = this.EncryptBlock(input:  input, inOff:  inOff, outBytes:  output, outOff:  outOff);
                return 8;
            }
            
            int val_2 = this.DecryptBlock(input:  input, inOff:  inOff, outBytes:  output, outOff:  outOff);
            return 8;
        }
        public virtual void Reset()
        {
        
        }
        private void SetKey(byte[] key)
        {
            int val_18;
            var val_19;
            var val_20;
            var val_21;
            int val_22;
            var val_23;
            int val_24;
            int val_25;
            int val_18 = key.Length;
            int val_1 = val_18 + 3;
            val_18 = val_18 + 6;
            var val_3 = ((val_1 < 0) ? (val_18) : (val_1)) >> 2;
            int[] val_4 = new int[0];
            if(key.Length != 0)
            {
                    var val_20 = 0;
                do
            {
                var val_7 = ((val_20 < 0) ? (val_20 + 3) : (val_20)) >> 2;
                val_18 = val_4[((long)((0 < 0x0 ? (0 + 3) : 0>>2) & 0x3FFFFFFF)) << 2];
                byte val_19 = key[0];
                val_20 = val_20 + 1;
                val_19 = val_19 << val_4.Length;
                val_19 = val_19 + val_18;
                mem2[0] = val_19;
            }
            while(val_20 != key.Length);
            
            }
            
            int val_21 = this._noRounds;
            val_21 = val_21 << 1;
            int val_8 = val_21 + 2;
            int[] val_9 = new int[0];
            this._S = val_9;
            val_19 = null;
            val_19 = null;
            val_20 = 0;
            val_9[0] = Org.BouncyCastle.Crypto.Engines.RC532Engine.P32;
            goto label_11;
            label_18:
            val_21 = null;
            val_21 = null;
            int val_11 = (Org.BouncyCastle.Crypto.Engines.RC532Engine.P32 - 1) + 1;
            val_18 = Org.BouncyCastle.Crypto.Engines.RC532Engine.Q32 + this._S[0];
            val_20 = 1;
            this._S[(long)Org.BouncyCastle.Crypto.Engines.RC532Engine.P32] = val_18;
            label_11:
            if((val_20 + 1) < this._S.Length)
            {
                goto label_18;
            }
            
            val_22 = val_4.Length;
            if(val_22 <= this._S.Length)
            {
                    val_22 = this._S.Length;
            }
            
            val_23 = val_22 + (val_22 << 1);
            if(val_23 < 1)
            {
                    return;
            }
            
            int val_24 = 0;
            int val_27 = 0;
            do
            {
                val_24 = this._S.Length;
                if(0 >= val_24)
            {
                    val_24 = this._S.Length;
            }
            
                int val_23 = this._S[0];
                var val_13 = val_24 + val_27;
                val_23 = val_13 + val_23;
                val_24 = val_23 >> 29;
                mem2[0] = val_24;
                val_25 = val_4.Length;
                if(0 >= val_25)
            {
                    val_25 = val_4.Length;
            }
            
                int val_25 = val_4[0];
                val_13 = val_24 + val_27;
                var val_26 = -val_13;
                val_26 = val_26 & 31;
                val_25 = val_13 + val_25;
                val_27 = val_25 >> val_26;
                mem2[0] = val_27;
                var val_14 = 0 + 1;
                var val_15 = 0 + 1;
                val_23 = val_23 - 1;
                val_18 = val_14 - ((val_14 / this._S.Length) * this._S.Length);
                val_20 = val_15 - ((val_15 / val_4.Length) * val_4.Length);
            }
            while(val_23 != 0);
        
        }
        private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
        {
            int val_6;
            int val_7;
            int val_8;
            val_6 = this._S[0];
            val_7 = val_6 + (this.BytesToWord(src:  input, srcOff:  inOff));
            val_8 = this._S[1] + (this.BytesToWord(src:  input, srcOff:  inOff + 4));
            if(this._noRounds >= 1)
            {
                    var val_11 = 1;
                do
            {
                val_7 = val_7 ^ val_8;
                val_7 = val_7 >> ((-val_8) & 31);
                var val_9 = (long)3 - 1;
                val_7 = this._S[val_9] + val_7;
                val_8 = val_7 ^ val_8;
                val_9 = (-val_7) & 31;
                val_8 = val_8 >> val_9;
                val_11 = val_11 + 1;
                val_6 = 3 + 2;
                val_8 = this._S[3] + val_8;
            }
            while(val_11 <= this._noRounds);
            
            }
            
            this.WordToBytes(word:  val_7, dst:  outBytes, dstOff:  outOff);
            this.WordToBytes(word:  val_8, dst:  outBytes, dstOff:  outOff + 4);
            return 8;
        }
        private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
        {
            var val_8;
            int val_9;
            var val_10;
            var val_11;
            int val_1 = this.BytesToWord(src:  input, srcOff:  inOff);
            inOff = inOff + 4;
            val_8 = val_1;
            val_9 = this._noRounds;
            val_10 = val_1.BytesToWord(src:  input, srcOff:  inOff);
            goto label_0;
            label_5:
            var val_3 = X26 + 4;
            var val_8 = (X26 + 4) + 32;
            int val_4 = val_8 & 31;
            val_8 = val_10 - val_8;
            val_10 = val_8 >> val_4;
            val_10 = val_10 ^ val_8;
            int val_9 = this._S[0];
            val_4 = val_10 & 31;
            val_9 = val_9 - 1;
            val_11 = -1;
            val_9 = val_8 - val_9;
            val_9 = val_9 >> val_4;
            val_8 = val_9 ^ val_10;
            label_0:
            if(val_9 > 0)
            {
                goto label_5;
            }
            
            this.WordToBytes(word:  val_8 - this._S[0], dst:  outBytes, dstOff:  outOff);
            this.WordToBytes(word:  val_10 - this._S[1], dst:  outBytes, dstOff:  outOff + 4);
            return 8;
        }
        private int RotateLeft(int x, int y)
        {
            var val_2 = -y;
            val_2 = val_2 & 31;
            return (int)x >> val_2;
        }
        private int RotateRight(int x, int y)
        {
            return (int)x >> (y & 31);
        }
        private int BytesToWord(byte[] src, int srcOff)
        {
            int val_4 = src.Length;
            if(val_4 <= srcOff)
            {
                    val_4 = src.Length;
            }
            
            int val_1 = srcOff + 1;
            if(val_1 >= val_4)
            {
                    val_4 = src.Length;
            }
            
            byte val_5 = src[(long)val_1];
            int val_2 = srcOff + 2;
            if(val_2 >= val_4)
            {
                    val_4 = src.Length;
            }
            
            byte val_6 = src[(long)val_2];
            byte val_7 = src[(long)srcOff + 3];
            return (int)src[(long)srcOff];
        }
        private void WordToBytes(int word, byte[] dst, int dstOff)
        {
            dst[(long)dstOff] = word;
            dst[(long)dstOff + 1] = word >> 8;
            dst[(long)dstOff + 2] = word >> 16;
            dst[(long)dstOff + 3] = word >> 24;
        }
        private static RC532Engine()
        {
            Org.BouncyCastle.Crypto.Engines.RC532Engine.P32 = -1209970333;
            Org.BouncyCastle.Crypto.Engines.RC532Engine.Q32 = -1640531527;
        }
    
    }

}
