using UnityEngine;

namespace Org.BouncyCastle.Crypto.Modes
{
    public class EaxBlockCipher : IAeadBlockCipher
    {
        // Fields
        private Org.BouncyCastle.Crypto.Modes.SicBlockCipher cipher;
        private bool forEncryption;
        private int blockSize;
        private Org.BouncyCastle.Crypto.IMac mac;
        private byte[] nonceMac;
        private byte[] associatedTextMac;
        private byte[] macBlock;
        private int macSize;
        private byte[] bufBlock;
        private int bufOff;
        private bool cipherInitialized;
        private byte[] initialAssociatedText;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public EaxBlockCipher(Org.BouncyCastle.Crypto.IBlockCipher cipher)
        {
            var val_12 = 0;
            val_12 = val_12 + 1;
            this.blockSize = cipher.GetBlockSize();
            this.mac = new Org.BouncyCastle.Crypto.Macs.CMac(cipher:  cipher);
            this.macBlock = new byte[0];
            var val_13 = 0;
            val_13 = val_13 + 1;
            int val_6 = this.mac.GetMacSize();
            this.associatedTextMac = new byte[0];
            var val_14 = 0;
            val_14 = val_14 + 1;
            int val_9 = this.mac.GetMacSize();
            this.nonceMac = new byte[0];
            this.cipher = new Org.BouncyCastle.Crypto.Modes.SicBlockCipher(cipher:  cipher);
        }
        public virtual string get_AlgorithmName()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.cipher.AlgorithmName + "/EAX"("/EAX");
        }
        public virtual Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
        {
            return (Org.BouncyCastle.Crypto.IBlockCipher)this.cipher;
        }
        public virtual int GetBlockSize()
        {
            if(this.cipher == null)
            {
                
            }
        
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            var val_18;
            int val_20;
            this.forEncryption = forEncryption;
            if(parameters == null)
            {
                goto label_5;
            }
            
            System.Byte[] val_3 = parameters.GetIV();
            this.initialAssociatedText = 0;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_18 = 2;
            int val_5 = this.mac.GetMacSize();
            int val_6 = (val_5 < 0) ? (val_5 + 1) : (val_5);
            val_6 = val_6 >> 1;
            this.macSize = val_6;
            val_20 = this.blockSize;
            if(forEncryption != true)
            {
                    val_20 = this.macSize + val_20;
            }
            
            this.bufBlock = new byte[0];
            byte[] val_9 = new byte[0];
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_18 = 0;
            this.mac.Init(parameters:  parameters.Parameters);
            val_9[(long)this.blockSize - 1] = 0;
            var val_22 = 0;
            val_22 = val_22 + 1;
            this.mac.BlockUpdate(input:  val_9, inOff:  0, len:  this.blockSize);
            if(val_3 == null)
            {
                goto label_24;
            }
            
            label_31:
            var val_23 = 0;
            val_23 = val_23 + 1;
            goto label_29;
            label_24:
            if(this.mac != null)
            {
                goto label_31;
            }
            
            goto label_31;
            label_29:
            this.mac.BlockUpdate(input:  val_3, inOff:  0, len:  val_3.Length);
            var val_24 = 0;
            val_24 = val_24 + 1;
            int val_15 = this.mac.DoFinal(output:  this.nonceMac, outOff:  0);
            Org.BouncyCastle.Crypto.Parameters.ParametersWithIV val_16 = new Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(parameters:  0, iv:  this.nonceMac);
            if(this.cipher != null)
            {
                    return;
            }
            
            return;
            label_5:
            System.ArgumentException val_19 = new System.ArgumentException(message:  "invalid parameters passed to EAX");
        }
        private void InitCipher()
        {
            if(this.cipherInitialized != false)
            {
                    return;
            }
            
            this.cipherInitialized = true;
            var val_6 = 0;
            val_6 = val_6 + 1;
            int val_2 = this.mac.DoFinal(output:  this.associatedTextMac, outOff:  0);
            byte[] val_3 = new byte[0];
            val_3[(long)this.blockSize - 1] = 2;
            var val_7 = 0;
            val_7 = val_7 + 1;
            this.mac.BlockUpdate(input:  val_3, inOff:  0, len:  this.blockSize);
        }
        private void CalculateMac()
        {
            var val_5;
            byte[] val_1 = new byte[0];
            var val_5 = 0;
            val_5 = val_5 + 1;
            int val_3 = this.mac.DoFinal(output:  val_1, outOff:  0);
            val_5 = 0;
            goto label_6;
            label_16:
            byte val_6 = this.nonceMac[0];
            val_6 = this.associatedTextMac[0] ^ val_6 ^ val_1[0];
            val_5 = 1;
            this.macBlock[0] = val_6;
            label_6:
            if(val_5 < this.macBlock.Length)
            {
                goto label_16;
            }
        
        }
        public virtual void Reset()
        {
            this.Reset(clearMac:  true);
        }
        private void Reset(bool clearMac)
        {
            var val_12;
            int val_14;
            val_12 = this;
            var val_12 = 0;
            val_12 = val_12 + 1;
            this.mac.Reset();
            this.bufOff = 0;
            System.Array.Clear(array:  this.bufBlock, index:  0, length:  this.bufBlock.Length);
            if(clearMac != false)
            {
                    System.Array.Clear(array:  this.macBlock, index:  0, length:  this.macBlock.Length);
            }
            
            byte[] val_2 = new byte[0];
            val_2[(long)this.blockSize - 1] = 1;
            val_14 = this.blockSize;
            var val_13 = 0;
            val_13 = val_13 + 1;
            this.mac.BlockUpdate(input:  val_2, inOff:  0, len:  val_14);
            this.cipherInitialized = false;
            if(this.initialAssociatedText == null)
            {
                    return;
            }
            
            val_12 = ???;
            val_14 = ???;
            goto typeof(Org.BouncyCastle.Crypto.Modes.EaxBlockCipher).__il2cppRuntimeField_298;
        }
        public virtual void ProcessAadByte(byte input)
        {
            if(this.cipherInitialized != true)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                this.mac.Update(input:  input);
                return;
            }
            
            System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  "AAD data cannot be added after encryption/decryption processing has begun.");
        }
        public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
        {
            if(this.cipherInitialized != true)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                this.mac.BlockUpdate(input:  inBytes, inOff:  inOff, len:  len);
                return;
            }
            
            System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  "AAD data cannot be added after encryption/decryption processing has begun.");
        }
        public virtual int ProcessByte(byte input, byte[] outBytes, int outOff)
        {
            this.InitCipher();
            return this.Process(b:  input, outBytes:  outBytes, outOff:  outOff);
        }
        public virtual int ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff)
        {
            var val_3;
            var val_4;
            val_3 = len;
            int val_4 = inOff;
            this.InitCipher();
            val_4 = 0;
            if(val_3 == 0)
            {
                    return (int)val_4;
            }
            
            do
            {
                val_4 = (this.Process(b:  inBytes[(long)val_4], outBytes:  outBytes, outOff:  val_4 + outOff)) + val_4;
                val_3 = val_3 - 1;
                val_4 = val_4 + 1;
            }
            while(val_3 != 0);
            
            return (int)val_4;
        }
        public virtual int DoFinal(byte[] outBytes, int outOff)
        {
            System.Byte[] val_14;
            var val_17;
            string val_19;
            this.InitCipher();
            byte[] val_1 = new byte[0];
            this.bufOff = 0;
            if(this.forEncryption == false)
            {
                goto label_2;
            }
            
            Org.BouncyCastle.Crypto.Check.OutputLength(buf:  outBytes, off:  outOff, len:  this.macSize + this.bufOff, msg:  "Output buffer too short");
            val_14 = this.bufBlock;
            System.Array.Copy(sourceArray:  val_1, sourceIndex:  0, destinationArray:  outBytes, destinationIndex:  outOff, length:  this.bufOff);
            var val_12 = 0;
            val_12 = val_12 + 1;
            goto label_8;
            label_2:
            if()
            {
                goto label_9;
            }
            
            Org.BouncyCastle.Crypto.Check.OutputLength(buf:  outBytes, off:  outOff, len:  this.bufOff - this.macSize, msg:  "Output buffer too short");
            if()
            {
                goto label_10;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_15;
            label_8:
            this.mac.BlockUpdate(input:  val_1, inOff:  0, len:  this.bufOff);
            this.CalculateMac();
            System.Array.Copy(sourceArray:  this.macBlock, sourceIndex:  0, destinationArray:  outBytes, destinationIndex:  this.bufOff + outOff, length:  this.macSize);
            this.Reset(clearMac:  false);
            val_17 = this.macSize + this.bufOff;
            return (int)val_17;
            label_15:
            this.mac.BlockUpdate(input:  this.bufBlock, inOff:  0, len:  this.bufOff - this.macSize);
            val_14 = this.bufBlock;
            System.Array.Copy(sourceArray:  val_1, sourceIndex:  0, destinationArray:  outBytes, destinationIndex:  outOff, length:  this.bufOff - this.macSize);
            label_10:
            this.CalculateMac();
            if((this.VerifyMac(mac:  this.bufBlock, off:  this.bufOff - this.macSize)) == false)
            {
                goto label_18;
            }
            
            this.Reset(clearMac:  false);
            val_17 = this.bufOff - this.macSize;
            return (int)val_17;
            label_9:
            val_19 = "data too short";
            goto label_19;
            label_18:
            val_19 = "mac check in EAX failed";
            label_19:
            null = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  val_19);
        }
        public virtual byte[] GetMac()
        {
            byte[] val_1 = new byte[0];
            System.Array.Copy(sourceArray:  this.macBlock, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  0, length:  this.macSize);
            return (System.Byte[])val_1;
        }
        public virtual int GetUpdateOutputSize(int len)
        {
            var val_2 = this.bufOff + len;
            if(this.forEncryption != true)
            {
                    val_2 = val_2 - this.macSize;
                if()
            {
                    return 0;
            }
            
            }
            
            val_2 = val_2 / this.blockSize;
            return (int)val_2 * this.blockSize;
        }
        public virtual int GetOutputSize(int len)
        {
            int val_3 = this.bufOff;
            int val_4 = this.macSize;
            val_3 = val_3 + len;
            if(this.forEncryption != false)
            {
                    return (int)val_4 + val_3;
            }
            
            val_4 = val_3 - val_4;
            return (int)() ? 0 : (val_4);
        }
        private int Process(byte b, byte[] outBytes, int outOff)
        {
            System.Byte[] val_4;
            var val_5;
            this.bufOff = this.bufOff + 1;
            this.bufBlock[this.bufOff] = b;
            val_4 = this.bufBlock;
            if(this.bufOff != this.bufBlock.Length)
            {
                goto label_4;
            }
            
            Org.BouncyCastle.Crypto.Check.OutputLength(buf:  outBytes, off:  outOff, len:  this.blockSize, msg:  "Output buffer is too short");
            if(this.forEncryption == false)
            {
                goto label_5;
            }
            
            val_4 = this.blockSize;
            val_5 = this.cipher;
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_11;
            label_4:
            val_5 = 0;
            return (int)val_5;
            label_5:
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_17;
            label_11:
            this.mac.BlockUpdate(input:  outBytes, inOff:  outOff, len:  val_4);
            goto label_18;
            label_17:
            this.mac.BlockUpdate(input:  this.bufBlock, inOff:  0, len:  this.blockSize);
            val_4 = this.bufBlock;
            val_5 = this.cipher;
            label_18:
            this.bufOff = 0;
            if(this.forEncryption == true)
            {
                    return (int)val_5;
            }
            
            System.Array.Copy(sourceArray:  this.bufBlock, sourceIndex:  this.blockSize, destinationArray:  this.bufBlock, destinationIndex:  0, length:  this.macSize);
            this.bufOff = this.macSize;
            return (int)val_5;
        }
        private bool VerifyMac(byte[] mac, int off)
        {
            var val_3;
            if(this.macSize >= 1)
            {
                    var val_6 = 0;
                var val_5 = 0;
                do
            {
                byte val_4 = mac[(long)off + val_5];
                val_5 = val_5 + 1;
                val_4 = val_4 ^ this.macBlock[0];
                val_4 = val_4 & 255;
                val_6 = val_6 | val_4;
            }
            while(val_5 < this.macSize);
            
                var val_2 = (val_6 == 0) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 1;
            return (bool)val_3;
        }
    
    }

}
