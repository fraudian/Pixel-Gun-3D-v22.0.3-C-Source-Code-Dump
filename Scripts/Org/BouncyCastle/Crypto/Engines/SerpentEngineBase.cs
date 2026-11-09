using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public abstract class SerpentEngineBase : IBlockCipher
    {
        // Fields
        protected static readonly int BlockSize;
        internal const int ROUNDS = 32;
        internal const int PHI = -1640531527;
        protected bool encrypting;
        protected int[] wKey;
        protected int X0;
        protected int X1;
        protected int X2;
        protected int X3;
        
        // Properties
        public virtual string AlgorithmName { get; }
        public virtual bool IsPartialBlockOkay { get; }
        
        // Methods
        protected SerpentEngineBase()
        {
        
        }
        public virtual void Init(bool encrypting, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            object val_9;
            var val_10;
            val_9 = parameters;
            if(val_9 != null)
            {
                    this.encrypting = encrypting;
                val_9 = 0;
                System.Byte[] val_5 = val_9.GetKey();
                this.wKey = this;
                return;
            }
            
            val_10 = new System.ArgumentException(message:  "invalid parameter passed to " + this + " init - "(" init - ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_9)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_9)));
        }
        public virtual string get_AlgorithmName()
        {
            return "Serpent";
        }
        public virtual bool get_IsPartialBlockOkay()
        {
            return false;
        }
        public virtual int GetBlockSize()
        {
            null = null;
            return (int)Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.PHI;
        }
        public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
        {
            var val_3;
            var val_4;
            if(this.wKey != null)
            {
                    val_3 = null;
                val_3 = null;
                Org.BouncyCastle.Crypto.Check.DataLength(buf:  input, off:  inOff, len:  Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.PHI, msg:  "input buffer too short");
                Org.BouncyCastle.Crypto.Check.OutputLength(buf:  output, off:  outOff, len:  Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.PHI, msg:  "output buffer too short");
                if(this.encrypting != false)
            {
                
            }
            
                val_4 = null;
                val_4 = null;
                return (int)Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.PHI;
            }
            
            System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  this + " not initialised");
        }
        public virtual void Reset()
        {
        
        }
        protected static int RotateLeft(int x, int bits)
        {
            var val_1 = -bits;
            val_1 = val_1 & 31;
            x = x >> val_1;
            return (int)x;
        }
        private static int RotateRight(int x, int bits)
        {
            x = x >> (bits & 31);
            return (int)x;
        }
        protected void Sb0(int a, int b, int c, int d)
        {
            int val_1 = d ^ a;
            int val_2 = val_1 ^ c;
            val_1 = val_1 & b;
            int val_3 = d & a;
            int val_4 = val_2 ^ b;
            val_1 = val_1 ^ a;
            val_3 = val_4 ^ val_3;
            val_4 = (val_1 | c) ^ val_4;
            int val_7 = val_3 & val_1 ^ val_2;
            this.X2 = val_4;
            this.X3 = val_3;
            this.X0 = val_1;
            this.X1 = val_3;
        }
        protected void Ib0(int a, int b, int c, int d)
        {
            int val_1 = b ^ a;
            int val_2 = val_1 | (~a);
            val_2 = val_2 ^ d;
            int val_3 = val_1 & d;
            int val_4 = val_2 ^ c;
            val_1 = val_4 ^ val_1;
            val_3 = val_1 & val_3;
            val_2 = val_3 ^ val_2;
            val_3 = val_2 | val_4;
            val_3 = val_3 ^ (val_2 & a);
            val_4 = val_4 ^ val_3 ^ val_3;
            this.X0 = val_4;
            this.X1 = val_2;
            this.X2 = val_1;
            this.X3 = val_3;
        }
        protected void Sb1(int a, int b, int c, int d)
        {
            int val_1 = a ^ b;
            int val_2 = a | (~val_1);
            val_2 = val_2 ^ c;
            int val_3 = d | (~val_1);
            val_3 = val_3 ^ b;
            int val_5 = val_3 & val_2;
            val_3 = val_3 ^ val_2;
            val_5 = val_1 ^ val_5;
            val_1 = val_1 & val_3;
            val_3 = val_5 ^ val_3;
            val_1 = val_1 ^ val_2;
            this.X2 = val_2 ^ d;
            this.X3 = val_5;
            this.X0 = val_1;
            this.X1 = val_3;
        }
        protected void Ib1(int a, int b, int c, int d)
        {
            int val_1 = d ^ b;
            int val_2 = val_1 & b;
            val_2 = val_2 ^ a;
            int val_3 = val_2 ^ val_1;
            val_1 = val_2 & val_1;
            int val_4 = val_3 ^ c;
            val_1 = val_1 ^ b;
            int val_5 = val_4 | val_1;
            val_1 = val_4 ^ val_1;
            val_2 = val_5 ^ val_2;
            val_1 = val_1 | (~val_2);
            val_1 = val_1 ^ val_3;
            this.X2 = val_1;
            this.X3 = val_4;
            this.X0 = val_5;
            this.X1 = val_2;
        }
        protected void Sb2(int a, int b, int c, int d)
        {
            int val_1 = d ^ b;
            val_1 = val_1 ^ (c & (~a));
            int val_3 = val_1 ^ c;
            int val_6 = ~d;
            val_3 = val_3 & b;
            val_6 = val_6 & (~a);
            int val_5 = val_3 ^ W10;
            val_3 = val_3 | d;
            val_6 = val_6 ^ b;
            val_3 = (val_1 | W10) & val_3;
            val_6 = val_6 ^ val_5;
            val_3 = val_3 ^ a;
            val_6 = val_6 ^ val_3;
            this.X2 = val_3;
            this.X3 = val_5;
            this.X0 = val_1;
            this.X1 = val_6;
        }
        protected void Ib2(int a, int b, int c, int d)
        {
            int val_1 = d ^ b;
            int val_2 = a | (~val_1);
            int val_3 = c ^ a;
            int val_4 = val_1 ^ c;
            val_2 = val_2 ^ d;
            int val_5 = val_4 & b;
            val_2 = val_2 | val_3;
            val_5 = val_5 ^ val_3;
            val_1 = val_2 ^ val_1;
            val_3 = (d & (~val_4)) ^ val_3;
            val_2 = val_5 | val_1;
            val_3 = val_3 ^ val_2;
            this.X2 = val_3;
            this.X3 = val_1;
            this.X0 = val_5;
            this.X1 = val_4;
        }
        protected void Sb3(int a, int b, int c, int d)
        {
            int val_1 = b ^ a;
            int val_2 = d | a;
            int val_3 = c & a;
            int val_4 = val_2 & val_1;
            val_2 = val_2 ^ b;
            val_3 = val_4 | val_3;
            int val_5 = d ^ c;
            val_2 = val_2 ^ val_3;
            val_4 = val_3 ^ val_5;
            val_5 = val_2 & val_5;
            int val_6 = b & (~d);
            val_1 = val_5 ^ val_1;
            val_6 = val_6 ^ c;
            val_5 = val_4 & val_1;
            val_2 = val_5 ^ val_2;
            val_5 = val_6 ^ val_5;
            this.X0 = val_1;
            this.X1 = val_2;
            this.X2 = val_4;
            this.X3 = val_5;
        }
        protected void Ib3(int a, int b, int c, int d)
        {
            int val_1 = c ^ b;
            int val_2 = val_1 & b;
            val_2 = val_2 ^ a;
            int val_3 = val_2 | d;
            int val_4 = val_3 ^ val_1;
            val_1 = val_3 | val_1;
            int val_5 = b | a;
            int val_6 = val_2 ^ c;
            val_1 = val_1 ^ d;
            val_6 = val_6 ^ val_1;
            val_1 = val_1 ^ val_5;
            val_5 = val_4 & val_1;
            val_1 = val_4 ^ val_1;
            val_5 = val_5 ^ val_2;
            val_1 = val_1 ^ val_5;
            this.X2 = val_6;
            this.X3 = val_5;
            this.X0 = val_4;
            this.X1 = val_1;
        }
        protected void Sb4(int a, int b, int c, int d)
        {
            int val_1 = d ^ a;
            int val_2 = val_1 & d;
            int val_3 = val_1 | (~b);
            val_2 = val_2 ^ c;
            int val_4 = val_2 | b;
            val_3 = val_2 ^ val_3;
            val_1 = val_4 ^ val_1;
            val_4 = val_4 & W11;
            val_4 = (val_3 & a) ^ val_4;
            val_2 = val_2 ^ a;
            this.X2 = val_4;
            this.X3 = val_1;
            int val_6 = val_4 & W11;
            val_6 = val_2 ^ val_6;
            this.X0 = val_3;
            this.X1 = val_6;
        }
        protected void Ib4(int a, int b, int c, int d)
        {
            int val_1 = d | c;
            val_1 = val_1 & a;
            val_1 = val_1 ^ b;
            int val_2 = val_1 & a;
            val_2 = val_2 ^ c;
            int val_3 = val_2 ^ d;
            int val_4 = val_3 | (~a);
            val_2 = val_3 & val_2;
            val_4 = val_4 ^ d;
            val_2 = val_2 ^ val_1;
            val_1 = val_4 & val_1;
            val_1 = val_1 ^ val_3;
            this.X0 = val_2 ^ val_4;
            this.X1 = val_3;
            this.X2 = val_1;
            this.X3 = val_2;
        }
        protected void Sb5(int a, int b, int c, int d)
        {
            int val_1 = d ^ a;
            int val_2 = b ^ a;
            int val_3 = val_1 | val_2;
            int val_4 = W9 ^ val_3;
            val_3 = val_4 & d;
            int val_5 = val_4 ^ val_2;
            val_5 = val_5 ^ val_3;
            val_2 = val_3 | val_2;
            val_1 = (val_4 | (~a)) ^ val_1;
            val_3 = val_3 ^ b;
            this.X0 = val_4;
            this.X1 = val_5;
            val_4 = val_2 ^ val_1;
            val_1 = val_5 & val_1;
            val_1 = val_3 ^ val_1;
            this.X2 = val_4;
            this.X3 = val_1;
        }
        protected void Ib5(int a, int b, int c, int d)
        {
            int val_1 = b & (~c);
            val_1 = val_1 ^ d;
            int val_2 = d | a;
            int val_3 = c ^ a;
            int val_4 = val_1 & a;
            val_2 = val_2 & b;
            int val_5 = W9 ^ val_4;
            val_3 = val_4 | val_3;
            val_4 = val_5 | b;
            val_2 = val_3 ^ val_2;
            this.X2 = val_2;
            this.X3 = val_5;
            val_5 = val_4 & a;
            val_1 = val_5 ^ val_1;
            this.X0 = W12 ^ val_4;
            this.X1 = val_1;
        }
        protected void Sb6(int a, int b, int c, int d)
        {
            int val_1 = d ^ a;
            int val_2 = val_1 | (~a);
            val_2 = val_2 ^ c;
            int val_3 = val_2 ^ b;
            int val_4 = val_1 ^ b;
            val_1 = val_3 | val_1;
            val_1 = val_1 ^ d;
            int val_5 = val_1 & val_2;
            val_1 = val_1 ^ val_2;
            val_5 = val_5 ^ val_4;
            val_4 = val_1 & val_4;
            val_1 = val_5 ^ val_1;
            this.X0 = val_1;
            this.X1 = val_3;
            this.X2 = val_5;
            this.X3 = val_4;
        }
        protected void Ib6(int a, int b, int c, int d)
        {
            int val_1 = b ^ a;
            int val_2 = c | (~a);
            int val_3 = val_1 ^ c;
            val_2 = val_2 ^ d;
            int val_5 = d & (~a);
            val_1 = (val_2 & val_3) ^ val_1;
            val_5 = val_5 ^ val_3;
            val_3 = val_1 | b;
            val_2 = val_3 ^ val_2;
            val_3 = val_2 | b;
            val_1 = val_3 ^ val_1;
            val_5 = val_5 ^ val_3;
            this.X0 = val_1;
            this.X1 = val_2 ^ val_3;
            this.X2 = val_5;
            this.X3 = val_2;
        }
        protected void Sb7(int a, int b, int c, int d)
        {
            int val_1 = c ^ b;
            int val_2 = val_1 & c;
            val_2 = val_2 ^ d;
            int val_3 = val_1 | d;
            int val_4 = val_2 ^ a;
            val_3 = val_4 & val_3;
            val_4 = val_4 & a;
            val_3 = val_3 ^ b;
            val_1 = val_4 ^ val_1;
            int val_5 = val_3 & (~val_2);
            val_5 = val_5 ^ a;
            int val_6 = val_5 & val_1;
            val_2 = val_6 ^ val_2;
            val_6 = val_1 & val_2;
            this.X0 = val_5;
            this.X1 = val_3;
            this.X2 = val_2;
            this.X3 = val_1;
        }
        protected void Ib7(int a, int b, int c, int d)
        {
            int val_1 = b & a;
            int val_2 = b | a;
            val_1 = val_1 | c;
            val_2 = val_2 & d;
            int val_3 = val_2 ^ val_1;
            val_2 = val_2 ^ b;
            int val_4 = val_3 ^ d;
            val_2 = val_2 | (~val_4);
            val_2 = val_2 ^ a;
            val_4 = val_2 | d;
            val_1 = val_2 ^ val_1;
            val_4 = val_2 ^ c ^ val_4;
            val_1 = val_1 ^ val_4;
            val_1 = val_1 ^ (val_3 & a);
            this.X2 = val_1;
            this.X3 = val_3;
            this.X0 = val_4;
            this.X1 = val_2;
        }
        protected void LT()
        {
            int val_5 = this.X1;
            int val_7 = this.X2;
            int val_6 = this.X3;
            int val_1 = this.X0 >> 19;
            val_5 = val_5 ^ (((this.X0) << (32-19)) | ((this.X0) << 19));
            val_1 = (val_7 >> 29) ^ (val_1 << 3);
            val_5 = val_5 ^ (((this.X2) << (32-29)) | ((this.X2) << 29));
            val_1 = val_1 ^ val_6;
            val_5 = val_5 >> 31;
            val_6 = val_1 >> 25;
            val_7 = val_6 ^ (((this.X2) << (32-29)) | ((this.X2) << 29));
            int val_4 = (val_5 ^ (((this.X0) << (32-19)) | ((this.X0) << 19))) ^ ((((((this.X2 >> 29) ^ ((this.X0 >> 19)) << 3) ^ this.X3)) << (32-25)) | (((((this.X2 >> 29) ^ ((this.X0 >> 19)) << 3) ^ this.X3)) << 25));
            val_7 = val_7 ^ (val_5 << 7);
            val_4 = val_4 >> 27;
            val_7 = val_7 >> 10;
            this.X0 = val_4;
            this.X1 = val_5;
            this.X2 = val_7;
            this.X3 = val_6;
        }
        protected void InverseLT()
        {
            int val_5 = this.X3;
            int val_6 = this.X1;
            int val_1 = val_5 ^ (((this.X2) << (32-22)) | ((this.X2) << 22));
            int val_2 = val_6 ^ val_5;
            int val_3 = val_1 ^ (val_6 << 7);
            int val_4 = val_2 ^ (((this.X0) << (32-5)) | ((this.X0) << 5));
            val_5 = val_3 ^ (((this.X3) << (32-7)) | ((this.X3) << 7));
            val_6 = val_3 ^ (((this.X1) << (32-1)) | ((this.X1) << 1));
            val_2 = val_4 >> 13;
            val_5 = val_5 ^ (val_4 << 3);
            val_6 = val_6 ^ val_4;
            this.X2 = val_1;
            this.X3 = val_5;
            this.X0 = val_2;
            this.X1 = val_6;
        }
        protected abstract int[] MakeWorkingKey(byte[] key); // 0
        protected abstract void EncryptBlock(byte[] input, int inOff, byte[] output, int outOff); // 0
        protected abstract void DecryptBlock(byte[] input, int inOff, byte[] output, int outOff); // 0
        private static SerpentEngineBase()
        {
            Org.BouncyCastle.Crypto.Engines.SerpentEngineBase.PHI = 16;
        }
    
    }

}
