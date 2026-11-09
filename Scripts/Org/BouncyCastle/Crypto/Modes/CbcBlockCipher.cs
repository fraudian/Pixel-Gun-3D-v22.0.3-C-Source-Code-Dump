using UnityEngine;

namespace Org.BouncyCastle.Crypto.Modes
{
    public class CbcBlockCipher : IBlockCipher
    {
        // Fields
        private byte[] IV;
        private byte[] cbcV;
        private byte[] cbcNextV;
        private int blockSize;
        private Org.BouncyCastle.Crypto.IBlockCipher cipher;
        private bool encrypting;
        
        // Properties
        public string AlgorithmName { get; }
        public bool IsPartialBlockOkay { get; }
        
        // Methods
        public CbcBlockCipher(Org.BouncyCastle.Crypto.IBlockCipher cipher)
        {
            this.cipher = cipher;
            var val_6 = 0;
            val_6 = val_6 + 1;
            this.blockSize = cipher.GetBlockSize();
            this.IV = new byte[0];
            this.cbcV = new byte[0];
            this.cbcNextV = new byte[0];
        }
        public Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
        {
            return (Org.BouncyCastle.Crypto.IBlockCipher)this.cipher;
        }
        public void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            bool val_10;
            string val_13;
            val_10 = forEncryption;
            this.encrypting = val_10;
            if(parameters == null)
            {
                goto label_1;
            }
            
            this.Reset();
            val_10 = this.cipher;
            var val_10 = 0;
            val_10 = val_10 + 1;
            goto label_8;
            label_1:
            this.Reset();
            if(((this.encrypting == true) ? 1 : 0) == ((this.encrypting == true) ? 1 : 0))
            {
                    return;
            }
            
            val_13 = "cannot change encrypting state without providing key.";
            goto label_10;
            label_8:
            val_10.Init(forEncryption:  (this.encrypting == true) ? 1 : 0, parameters:  parameters);
            return;
            label_10:
            null = new System.ArgumentException(message:  null);
        }
        public string get_AlgorithmName()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.cipher.AlgorithmName + "/CBC"("/CBC");
        }
        public bool get_IsPartialBlockOkay()
        {
            return false;
        }
        public int GetBlockSize()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.GetBlockSize();
        }
        public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
        {
            if(this.encrypting == false)
            {
                    return this.DecryptBlock(input:  input, inOff:  inOff, outBytes:  output, outOff:  outOff);
            }
            
            return this.EncryptBlock(input:  input, inOff:  inOff, outBytes:  output, outOff:  outOff);
        }
        public void Reset()
        {
            System.Array.Copy(sourceArray:  this.IV, sourceIndex:  0, destinationArray:  this.cbcV, destinationIndex:  0, length:  this.IV.Length);
            System.Array.Clear(array:  this.cbcNextV, index:  0, length:  this.cbcNextV.Length);
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.cipher.Reset();
        }
        private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
        {
            if((this.blockSize + inOff) <= input.Length)
            {
                    if(this.blockSize >= 1)
            {
                    var val_8 = 0;
                do
            {
                byte val_7 = input[(long)inOff + val_8];
                val_8 = val_8 + 1;
                val_7 = val_7 ^ this.cbcV[0];
                mem2[0] = val_7;
            }
            while(val_8 < this.blockSize);
            
            }
            
                var val_9 = 0;
                val_9 = val_9 + 1;
                System.Array.Copy(sourceArray:  outBytes, sourceIndex:  outOff, destinationArray:  this.cbcV, destinationIndex:  0, length:  this.cbcV.Length);
                return (int)this.cipher.ProcessBlock(inBuf:  this.cbcV, inOff:  0, outBuf:  outBytes, outOff:  outOff);
            }
            
            Org.BouncyCastle.Crypto.DataLengthException val_5 = new Org.BouncyCastle.Crypto.DataLengthException(message:  "input buffer too short");
        }
        private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
        {
            System.Byte[] val_7;
            if((this.blockSize + inOff) <= input.Length)
            {
                    System.Array.Copy(sourceArray:  input, sourceIndex:  inOff, destinationArray:  this.cbcNextV, destinationIndex:  0, length:  this.blockSize);
                var val_7 = 0;
                val_7 = val_7 + 1;
                if(this.blockSize > 0)
            {
                    var val_9 = 0;
                val_7 = this.cbcV;
                do
            {
                var val_5 = mem[this.cbcV] + 0;
                byte val_10 = (mem[this.cbcV] + 0) + 32;
                val_9 = val_9 + 1;
                val_10 = val_10 ^ (outBytes[(long)outOff + val_9]);
                mem2[0] = val_10;
            }
            while(val_9 < this.blockSize);
            
            }
            else
            {
                    val_7 = this.cbcV;
            }
            
                mem2[0] = this.cbcNextV;
                this.cbcNextV = mem[this.cbcV];
                return (int)this.cipher.ProcessBlock(inBuf:  input, inOff:  inOff, outBuf:  outBytes, outOff:  outOff);
            }
            
            Org.BouncyCastle.Crypto.DataLengthException val_6 = new Org.BouncyCastle.Crypto.DataLengthException(message:  "input buffer too short");
        }
    
    }

}
