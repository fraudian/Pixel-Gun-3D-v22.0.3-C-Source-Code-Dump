using UnityEngine;

namespace Org.BouncyCastle.Crypto.Macs
{
    public class CfbBlockCipherMac : IMac
    {
        // Fields
        private byte[] mac;
        private byte[] Buffer;
        private int bufOff;
        private Org.BouncyCastle.Crypto.Macs.MacCFBBlockCipher cipher;
        private Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding;
        private int macSize;
        
        // Properties
        public string AlgorithmName { get; }
        
        // Methods
        public CfbBlockCipherMac(Org.BouncyCastle.Crypto.IBlockCipher cipher)
        {
            var val_6 = 0;
            val_6 = val_6 + 1;
            int val_3 = cipher.GetBlockSize() << 3;
            int val_5 = ((val_3 < 0) ? 1 : (val_3)) >> 1;
        }
        public CfbBlockCipherMac(Org.BouncyCastle.Crypto.IBlockCipher cipher, Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding)
        {
            var val_6 = 0;
            val_6 = val_6 + 1;
            int val_3 = cipher.GetBlockSize() << 3;
            int val_5 = ((val_3 < 0) ? 1 : (val_3)) >> 1;
        }
        public CfbBlockCipherMac(Org.BouncyCastle.Crypto.IBlockCipher cipher, int cfbBitSize, int macSizeInBits)
        {
        
        }
        public CfbBlockCipherMac(Org.BouncyCastle.Crypto.IBlockCipher cipher, int cfbBitSize, int macSizeInBits, Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding)
        {
            if((macSizeInBits & 7) == 0)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                int val_3 = cipher.GetBlockSize();
                this.mac = new byte[0];
                int val_7 = (macSizeInBits < 0) ? (macSizeInBits + 7) : macSizeInBits;
                val_7 = val_7 >> 3;
                this.cipher = new Org.BouncyCastle.Crypto.Macs.MacCFBBlockCipher(cipher:  cipher, bitBlockSize:  cfbBitSize);
                this.padding = padding;
                this.macSize = val_7;
                this.Buffer = new byte[0];
                this.bufOff = 0;
                return;
            }
            
            System.ArgumentException val_9 = new System.ArgumentException(message:  "MAC size must be multiple of 8");
        }
        public string get_AlgorithmName()
        {
            if(this.cipher != null)
            {
                    return this.cipher.AlgorithmName;
            }
            
            return this.cipher.AlgorithmName;
        }
        public void Init(Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            this.Reset();
            this.cipher.Init(forEncryption:  false, parameters:  parameters);
        }
        public int GetMacSize()
        {
            return (int)this.macSize;
        }
        public void Update(byte input)
        {
            int val_3;
            if(this.bufOff == this.Buffer.Length)
            {
                    int val_1 = this.cipher.ProcessBlock(input:  this.Buffer, inOff:  0, outBytes:  this.mac, outOff:  0);
                val_3 = 0;
                this.bufOff = 0;
            }
            else
            {
                    val_3 = this.bufOff;
            }
            
            this.bufOff = val_3 + 1;
            this.Buffer[(long)val_3] = input;
        }
        public void BlockUpdate(byte[] input, int inOff, int len)
        {
            int val_5;
            int val_6;
            int val_7;
            int val_8;
            val_5 = len;
            val_6 = inOff;
            if((val_5 & 2147483648) == 0)
            {
                    val_7 = this.bufOff;
                val_8 = this.cipher.blockSize - val_7;
                if(val_8 < val_5)
            {
                    System.Array.Copy(sourceArray:  input, sourceIndex:  val_6, destinationArray:  this.Buffer, destinationIndex:  val_7, length:  val_8);
                int val_1 = this.cipher.ProcessBlock(input:  this.Buffer, inOff:  0, outBytes:  this.mac, outOff:  0);
                val_5 = val_5 - val_8;
                val_6 = val_8 + val_6;
                this.bufOff = 0;
                if(val_5 > this.cipher.blockSize)
            {
                    do
            {
                val_8 = this.mac;
                int val_2 = this.cipher.ProcessBlock(input:  input, inOff:  val_6, outBytes:  val_8, outOff:  0);
                val_5 = val_5 - this.cipher.blockSize;
                val_6 = val_6 + this.cipher.blockSize;
            }
            while(val_5 > this.cipher.blockSize);
            
                val_7 = this.bufOff;
            }
            else
            {
                    val_7 = 0;
            }
            
            }
            
                System.Array.Copy(sourceArray:  input, sourceIndex:  val_6, destinationArray:  this.Buffer, destinationIndex:  0, length:  val_5);
                int val_4 = this.bufOff;
                val_4 = val_4 + val_5;
                this.bufOff = val_4;
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Can\'t have a negative input length!");
        }
        public int DoFinal(byte[] output, int outOff)
        {
            System.Byte[] val_4;
            if(this.padding == null)
            {
                goto label_2;
            }
            
            val_4 = this;
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_6;
            label_2:
            val_4 = this.Buffer;
            if(this.bufOff >= this.cipher.blockSize)
            {
                goto label_11;
            }
            
            do
            {
                this.bufOff = this.bufOff + 1;
                this.Buffer[(long)this.bufOff] = 0;
            }
            while(this.bufOff < this.cipher.blockSize);
            
            goto label_11;
            label_6:
            int val_3 = this.padding.AddPadding(input:  this.Buffer, inOff:  this.bufOff);
            label_11:
            int val_4 = this.cipher.ProcessBlock(input:  this.Buffer, inOff:  0, outBytes:  this.mac, outOff:  0);
            this.cipher.GetMacBlock(mac:  this.mac);
            System.Array.Copy(sourceArray:  this.mac, sourceIndex:  0, destinationArray:  output, destinationIndex:  outOff, length:  this.macSize);
            this.Reset();
            return (int)this.macSize;
        }
        public void Reset()
        {
            System.Array.Clear(array:  this.Buffer, index:  0, length:  this.Buffer.Length);
            this.bufOff = 0;
            this.cipher.Reset();
        }
    
    }

}
