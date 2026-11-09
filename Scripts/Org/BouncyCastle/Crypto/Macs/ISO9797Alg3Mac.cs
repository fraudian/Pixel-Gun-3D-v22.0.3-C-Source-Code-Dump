using UnityEngine;

namespace Org.BouncyCastle.Crypto.Macs
{
    public class ISO9797Alg3Mac : IMac
    {
        // Fields
        private byte[] mac;
        private byte[] buf;
        private int bufOff;
        private Org.BouncyCastle.Crypto.IBlockCipher cipher;
        private Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding;
        private int macSize;
        private Org.BouncyCastle.Crypto.Parameters.KeyParameter lastKey2;
        private Org.BouncyCastle.Crypto.Parameters.KeyParameter lastKey3;
        
        // Properties
        public string AlgorithmName { get; }
        
        // Methods
        public ISO9797Alg3Mac(Org.BouncyCastle.Crypto.IBlockCipher cipher)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            int val_3 = cipher.GetBlockSize() << 3;
        }
        public ISO9797Alg3Mac(Org.BouncyCastle.Crypto.IBlockCipher cipher, Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            int val_3 = cipher.GetBlockSize() << 3;
        }
        public ISO9797Alg3Mac(Org.BouncyCastle.Crypto.IBlockCipher cipher, int macSizeInBits)
        {
        
        }
        public ISO9797Alg3Mac(Org.BouncyCastle.Crypto.IBlockCipher cipher, int macSizeInBits, Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding)
        {
            string val_13;
            if((macSizeInBits & 7) == 0)
            {
                    if(cipher != null)
            {
                    int val_4 = (macSizeInBits < 0) ? (macSizeInBits + 7) : macSizeInBits;
                val_4 = val_4 >> 3;
                this.cipher = new Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(cipher:  cipher);
                this.padding = padding;
                this.macSize = val_4;
                var val_12 = 0;
                val_12 = val_12 + 1;
                int val_6 = cipher.GetBlockSize();
                this.mac = new byte[0];
                var val_13 = 0;
                val_13 = val_13 + 1;
                int val_9 = cipher.GetBlockSize();
                this.buf = new byte[0];
                this.bufOff = 0;
                return;
            }
            
                val_13 = "cipher must be instance of DesEngine";
            }
            else
            {
                    val_13 = "MAC size must be multiple of 8";
            }
            
            null = new System.ArgumentException(message:  val_13);
        }
        public string get_AlgorithmName()
        {
            return "ISO9797Alg3";
        }
        public void Init(Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            var val_20;
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_24;
            var val_25;
            Org.BouncyCastle.Crypto.ICipherParameters val_26;
            string val_30;
            var val_31;
            this.Reset();
            if(parameters == null)
            {
                goto label_5;
            }
            
            val_20 = null;
            if(0.Parameters != null)
            {
                    val_20 = null;
            }
            
            System.Byte[] val_8 = 0.GetKey();
            if(val_8.Length == 24)
            {
                goto label_17;
            }
            
            if(val_8.Length != 16)
            {
                goto label_18;
            }
            
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_9 = null;
            val_24 = val_9;
            val_9 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_8, keyOff:  0, keyLen:  8);
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_10 = null;
            val_25 = 8;
            val_10 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_8, keyOff:  8, keyLen:  8);
            this.lastKey2 = val_10;
            val_26 = val_24;
            goto label_19;
            label_17:
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_11 = null;
            val_26 = val_11;
            val_11 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_8, keyOff:  0, keyLen:  8);
            this.lastKey2 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_8, keyOff:  8, keyLen:  8);
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_13 = null;
            val_25 = 8;
            val_24 = val_13;
            val_13 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_8, keyOff:  16, keyLen:  8);
            label_19:
            this.lastKey3 = val_24;
            var val_19 = 0;
            val_19 = val_19 + 1;
            this.cipher.Init(forEncryption:  true, parameters:  val_11);
            return;
            label_5:
            val_30 = "parameters must be an instance of KeyParameter or ParametersWithIV";
            goto label_33;
            label_18:
            System.ArgumentException val_18 = null;
            val_30 = "Key must be either 112 or 168 bit long";
            label_33:
            val_18 = new System.ArgumentException(message:  val_30);
            val_31 = val_18;
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
            int val_2 = this.cipher.ProcessBlock(inBuf:  this.buf, inOff:  0, outBuf:  this.mac, outOff:  0);
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
            Org.BouncyCastle.Crypto.IBlockCipher val_10;
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
                val_10 = this.cipher;
                var val_10 = 0;
                val_10 = val_10 + 1;
                int val_5 = val_10.ProcessBlock(inBuf:  this.buf, inOff:  0, outBuf:  this.mac, outOff:  0);
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
                int val_7 = val_10.ProcessBlock(inBuf:  input, inOff:  val_7, outBuf:  this.mac, outOff:  0);
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
            Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding val_8;
            int val_9;
            System.Byte[] val_10;
            var val_11 = 0;
            val_11 = val_11 + 1;
            int val_2 = this.cipher.GetBlockSize();
            val_8 = this.padding;
            val_9 = this.bufOff;
            if(val_8 == null)
            {
                goto label_6;
            }
            
            if(val_9 != val_2)
            {
                goto label_7;
            }
            
            val_10 = this;
            var val_12 = 0;
            val_12 = val_12 + 1;
            goto label_12;
            label_6:
            val_10 = this.buf;
            if(val_9 >= val_2)
            {
                goto label_17;
            }
            
            do
            {
                this.bufOff = val_9 + 1;
                this.buf[(long)val_9] = 0;
            }
            while(this.bufOff < val_2);
            
            goto label_17;
            label_7:
            val_10 = this.buf;
            goto label_18;
            label_12:
            int val_5 = this.cipher.ProcessBlock(inBuf:  this.buf, inOff:  0, outBuf:  this.mac, outOff:  0);
            val_8 = this.padding;
            this.bufOff = 0;
            if(val_8 == null)
            {
                goto label_19;
            }
            
            val_9 = 0;
            label_18:
            var val_13 = 0;
            val_13 = val_13 + 1;
            int val_7 = val_8.AddPadding(input:  this.buf, inOff:  0);
            label_17:
            var val_14 = 0;
            val_14 = val_14 + 1;
            int val_9 = this.cipher.ProcessBlock(inBuf:  this.buf, inOff:  0, outBuf:  this.mac, outOff:  0);
            Org.BouncyCastle.Crypto.Engines.DesEngine val_10 = new Org.BouncyCastle.Crypto.Engines.DesEngine();
            System.Array.Copy(sourceArray:  this.mac, sourceIndex:  0, destinationArray:  output, destinationIndex:  outOff, length:  this.macSize);
            this.Reset();
            return (int)this.macSize;
            label_19:
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
