using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public class BufferedAsymmetricBlockCipher : BufferedCipherBase
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher;
        private byte[] buffer;
        private int bufOff;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public BufferedAsymmetricBlockCipher(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher)
        {
            this = new System.Object();
            this.cipher = cipher;
        }
        internal int GetBufferPosition()
        {
            return (int)this.bufOff;
        }
        public override string get_AlgorithmName()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.AlgorithmName;
        }
        public override int GetBlockSize()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.GetInputBlockSize();
        }
        public override int GetOutputSize(int length)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.GetOutputBlockSize();
        }
        public override int GetUpdateOutputSize(int length)
        {
            return 0;
        }
        public override void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            var val_8 = 0;
            val_8 = val_8 + 1;
            this.cipher.Init(forEncryption:  forEncryption, parameters:  parameters);
            var val_9 = 0;
            val_9 = val_9 + 1;
            int val_6 = this.cipher.GetInputBlockSize() + forEncryption;
            this.buffer = new byte[0];
            this.bufOff = 0;
        }
        public override byte[] ProcessByte(byte input)
        {
            if(this.bufOff < this.buffer.Length)
            {
                    this.bufOff = this.bufOff + 1;
                this.buffer[this.bufOff] = input;
                return 0;
            }
            
            Org.BouncyCastle.Crypto.DataLengthException val_2 = new Org.BouncyCastle.Crypto.DataLengthException(message:  "attempt to process message to long for cipher");
        }
        public override byte[] ProcessBytes(byte[] input, int inOff, int length)
        {
            System.Byte[] val_4;
            var val_5;
            if(length < 1)
            {
                    return 0;
            }
            
            if(input == null)
            {
                goto label_2;
            }
            
            val_4 = this.buffer;
            if((this.bufOff + length) > this.buffer.Length)
            {
                goto label_4;
            }
            
            System.Array.Copy(sourceArray:  input, sourceIndex:  inOff, destinationArray:  this.buffer, destinationIndex:  this.bufOff, length:  length);
            int val_4 = this.bufOff;
            val_4 = val_4 + length;
            this.bufOff = val_4;
            return 0;
            label_2:
            System.ArgumentNullException val_2 = null;
            val_5 = val_2;
            val_2 = new System.ArgumentNullException(paramName:  "input");
            goto label_5;
            label_4:
            Org.BouncyCastle.Crypto.DataLengthException val_3 = null;
            val_5 = val_3;
            val_3 = new Org.BouncyCastle.Crypto.DataLengthException(message:  "attempt to process message to long for cipher");
            label_5:
        }
        public override byte[] DoFinal()
        {
            var val_3;
            System.Byte[] val_4;
            if(this.bufOff > 0)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
            }
            else
            {
                    val_3 = null;
                val_3 = null;
                val_4 = Org.BouncyCastle.Crypto.BufferedCipherBase.EmptyBuffer;
                return (System.Byte[])val_4;
            }
            
            val_4 = this.cipher.ProcessBlock(inBuf:  this.buffer, inOff:  0, inLen:  this.bufOff);
            return (System.Byte[])val_4;
        }
        public override byte[] DoFinal(byte[] input, int inOff, int length)
        {
            goto typeof(Org.BouncyCastle.Crypto.BufferedAsymmetricBlockCipher).__il2cppRuntimeField_338;
        }
        public override void Reset()
        {
            if(this.buffer == null)
            {
                    return;
            }
            
            System.Array.Clear(array:  this.buffer, index:  0, length:  this.buffer.Length);
            this.bufOff = 0;
        }
    
    }

}
