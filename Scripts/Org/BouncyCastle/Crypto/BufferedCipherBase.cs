using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public abstract class BufferedCipherBase : IBufferedCipher
    {
        // Fields
        protected static readonly byte[] EmptyBuffer;
        
        // Properties
        public abstract string AlgorithmName { get; }
        
        // Methods
        public abstract string get_AlgorithmName(); // 0
        public abstract void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters); // 0
        public abstract int GetBlockSize(); // 0
        public abstract int GetOutputSize(int inputLen); // 0
        public abstract int GetUpdateOutputSize(int inputLen); // 0
        public abstract byte[] ProcessByte(byte input); // 0
        public virtual int ProcessByte(byte input, byte[] output, int outOff)
        {
            if(this == null)
            {
                    return (int)this;
            }
            
            if((1152921505521913856 + outOff) <= output.Length)
            {
                    this.CopyTo(array:  output, index:  outOff);
                return (int)this;
            }
            
            Org.BouncyCastle.Crypto.DataLengthException val_2 = new Org.BouncyCastle.Crypto.DataLengthException(message:  "output buffer too short");
        }
        public virtual byte[] ProcessBytes(byte[] input)
        {
            if(input == null)
            {
                
            }
        
        }
        public abstract byte[] ProcessBytes(byte[] input, int inOff, int length); // 0
        public virtual int ProcessBytes(byte[] input, byte[] output, int outOff)
        {
            if(input == null)
            {
                
            }
        
        }
        public virtual int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
        {
            if(this == null)
            {
                    return (int)this;
            }
            
            if((1152921505521913856 + outOff) <= output.Length)
            {
                    this.CopyTo(array:  output, index:  outOff);
                return (int)this;
            }
            
            Org.BouncyCastle.Crypto.DataLengthException val_2 = new Org.BouncyCastle.Crypto.DataLengthException(message:  "output buffer too short");
        }
        public abstract byte[] DoFinal(); // 0
        public virtual byte[] DoFinal(byte[] input)
        {
            if(input == null)
            {
                
            }
        
        }
        public abstract byte[] DoFinal(byte[] input, int inOff, int length); // 0
        public virtual int DoFinal(byte[] output, int outOff)
        {
            if(this == null)
            {
                goto label_1;
            }
            
            label_5:
            if((1152921505521913856 + outOff) > output.Length)
            {
                goto label_3;
            }
            
            this.CopyTo(array:  output, index:  outOff);
            return (int)this;
            label_1:
            if(output != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_3:
            Org.BouncyCastle.Crypto.DataLengthException val_2 = new Org.BouncyCastle.Crypto.DataLengthException(message:  "output buffer too short");
        }
        public virtual int DoFinal(byte[] input, byte[] output, int outOff)
        {
            if(input == null)
            {
                
            }
        
        }
        public virtual int DoFinal(byte[] input, int inOff, int length, byte[] output, int outOff)
        {
            Org.BouncyCastle.Crypto.BufferedCipherBase val_1 = this + outOff;
            return (int)2305843094883411104;
        }
        public abstract void Reset(); // 0
        protected BufferedCipherBase()
        {
        
        }
        private static BufferedCipherBase()
        {
            Org.BouncyCastle.Crypto.BufferedCipherBase.EmptyBuffer = new byte[0];
        }
    
    }

}
