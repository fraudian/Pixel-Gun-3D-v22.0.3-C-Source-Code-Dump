using UnityEngine;

namespace Org.BouncyCastle.Crypto.Macs
{
    public class CbcBlockCipherMac : IMac
    {
        // Fields
        private byte[] buf;
        private int bufOff;
        private Org.BouncyCastle.Crypto.IBlockCipher cipher;
        private Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding;
        private int macSize;
        
        // Properties
        public string AlgorithmName { get; }
        
        // Methods
        public CbcBlockCipherMac(Org.BouncyCastle.Crypto.IBlockCipher cipher)
        {
            var val_6 = 0;
            val_6 = val_6 + 1;
            int val_3 = cipher.GetBlockSize() << 3;
            int val_5 = ((val_3 < 0) ? 1 : (val_3)) >> 1;
        }
        public CbcBlockCipherMac(Org.BouncyCastle.Crypto.IBlockCipher cipher, Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding)
        {
            var val_6 = 0;
            val_6 = val_6 + 1;
            int val_3 = cipher.GetBlockSize() << 3;
            int val_5 = ((val_3 < 0) ? 1 : (val_3)) >> 1;
        }
        public CbcBlockCipherMac(Org.BouncyCastle.Crypto.IBlockCipher cipher, int macSizeInBits)
        {
        
        }
        public CbcBlockCipherMac(Org.BouncyCastle.Crypto.IBlockCipher cipher, int macSizeInBits, Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding)
        {
            if((macSizeInBits & 7) == 0)
            {
                    int val_4 = (macSizeInBits < 0) ? (macSizeInBits + 7) : macSizeInBits;
                val_4 = val_4 >> 3;
                this.cipher = new Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(cipher:  cipher);
                this.padding = padding;
                this.macSize = val_4;
                var val_9 = 0;
                val_9 = val_9 + 1;
                int val_6 = cipher.GetBlockSize();
                this.buf = new byte[0];
                this.bufOff = 0;
                return;
            }
            
            System.ArgumentException val_8 = new System.ArgumentException(message:  "MAC size must be multiple of 8");
        }
        public string get_AlgorithmName()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.AlgorithmName;
        }
        public void Init(Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            this.Reset();
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.cipher.Init(forEncryption:  true, parameters:  parameters);
        }
        public int GetMacSize()
        {
            return (int)this.macSize;
        }
        public void Update(byte input)
        {
            int val_3;
            if(this.bufOff != this.buf.Length)
            {
                goto label_2;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_7;
            label_2:
            val_3 = this.bufOff;
            goto label_8;
            label_7:
            int val_2 = this.cipher.ProcessBlock(inBuf:  this.buf, inOff:  0, outBuf:  this.buf, outOff:  0);
            val_3 = 0;
            this.bufOff = 0;
            label_8:
            this.bufOff = val_3 + 1;
            this.buf[0] = input;
        }
        public void BlockUpdate(byte[] input, int inOff, int len)
        {
            int val_6;
            int val_7;
            int val_9;
            System.Byte[] val_10;
            val_6 = len;
            val_7 = inOff;
            if((val_6 & 2147483648) == 0)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                int val_2 = this.cipher.GetBlockSize();
                val_9 = this.bufOff;
                int val_3 = val_2 - val_9;
                if(val_3 < val_6)
            {
                    System.Array.Copy(sourceArray:  input, sourceIndex:  val_7, destinationArray:  this.buf, destinationIndex:  val_9, length:  val_3);
                val_10 = this.buf;
                var val_10 = 0;
                val_10 = val_10 + 1;
                int val_5 = this.cipher.ProcessBlock(inBuf:  val_10, inOff:  0, outBuf:  val_10, outOff:  0);
                val_6 = val_6 - val_3;
                val_7 = val_3 + val_7;
                this.bufOff = 0;
                if(val_6 > val_2)
            {
                    do
            {
                val_10 = this.cipher;
                var val_11 = 0;
                val_11 = val_11 + 1;
                int val_7 = val_10.ProcessBlock(inBuf:  input, inOff:  val_7, outBuf:  this.buf, outOff:  0);
                val_6 = val_6 - val_2;
                val_7 = val_7 + val_2;
            }
            while(val_6 > val_2);
            
                val_9 = this.bufOff;
            }
            else
            {
                    val_9 = 0;
            }
            
            }
            
                System.Array.Copy(sourceArray:  input, sourceIndex:  val_7, destinationArray:  this.buf, destinationIndex:  0, length:  val_6);
                int val_12 = this.bufOff;
                val_12 = val_12 + val_6;
                this.bufOff = val_12;
                return;
            }
            
            System.ArgumentException val_8 = new System.ArgumentException(message:  "Can\'t have a negative input length!");
        }
        public int DoFinal(byte[] output, int outOff)
        {
            Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding val_7;
            int val_8;
            System.Byte[] val_9;
            System.Byte[] val_11;
            Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding val_12;
            var val_10 = 0;
            val_10 = val_10 + 1;
            int val_2 = this.cipher.GetBlockSize();
            val_7 = this.padding;
            val_8 = this.bufOff;
            if(val_7 == null)
            {
                goto label_6;
            }
            
            val_9 = this;
            if(val_8 != val_2)
            {
                goto label_7;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_12;
            label_6:
            val_9 = this.buf;
            if(val_8 >= val_2)
            {
                goto label_17;
            }
            
            do
            {
                this.bufOff = val_8 + 1;
                this.buf[(long)val_8] = 0;
            }
            while(this.bufOff < val_2);
            
            goto label_17;
            label_7:
            val_11 = this.buf;
            val_12 = val_7;
            goto label_18;
            label_12:
            int val_5 = this.cipher.ProcessBlock(inBuf:  this.buf, inOff:  0, outBuf:  this.buf, outOff:  0);
            val_12 = this.padding;
            val_11 = this.buf;
            this.bufOff = 0;
            val_8 = 0;
            val_7 = val_12;
            label_18:
            var val_12 = 0;
            val_12 = val_12 + 1;
            int val_7 = val_7.AddPadding(input:  val_11, inOff:  0);
            label_17:
            var val_13 = 0;
            val_13 = val_13 + 1;
            int val_9 = this.cipher.ProcessBlock(inBuf:  this.buf, inOff:  0, outBuf:  this.buf, outOff:  0);
            System.Array.Copy(sourceArray:  this.buf, sourceIndex:  0, destinationArray:  output, destinationIndex:  outOff, length:  this.macSize);
            this.Reset();
            return (int)this.macSize;
        }
        public void Reset()
        {
            System.Array.Clear(array:  this.buf, index:  0, length:  this.buf.Length);
            this.bufOff = 0;
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.cipher.Reset();
        }
    
    }

}
