using UnityEngine;

namespace Org.BouncyCastle.Crypto.Modes
{
    public class GcmBlockCipher : IAeadBlockCipher
    {
        // Fields
        private const int BlockSize = 16;
        private readonly Org.BouncyCastle.Crypto.IBlockCipher cipher;
        private readonly Org.BouncyCastle.Crypto.Modes.Gcm.IGcmMultiplier multiplier;
        private Org.BouncyCastle.Crypto.Modes.Gcm.IGcmExponentiator exp;
        private bool forEncryption;
        private int macSize;
        private byte[] nonce;
        private byte[] initialAssociatedText;
        private byte[] H;
        private byte[] J0;
        private byte[] bufBlock;
        private byte[] macBlock;
        private byte[] S;
        private byte[] S_at;
        private byte[] S_atPre;
        private byte[] counter;
        private uint blocksRemaining;
        private int bufOff;
        private ulong totalLength;
        private byte[] atBlock;
        private int atBlockPos;
        private ulong atLength;
        private ulong atLengthPre;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public GcmBlockCipher(Org.BouncyCastle.Crypto.IBlockCipher c)
        {
        
        }
        public GcmBlockCipher(Org.BouncyCastle.Crypto.IBlockCipher c, Org.BouncyCastle.Crypto.Modes.Gcm.IGcmMultiplier m)
        {
            Org.BouncyCastle.Crypto.Modes.Gcm.IGcmMultiplier val_5 = m;
            var val_6 = 0;
            val_6 = val_6 + 1;
            if(c.GetBlockSize() == 16)
            {
                    if(val_5 == null)
            {
                    Org.BouncyCastle.Crypto.Modes.Gcm.Tables8kGcmMultiplier val_3 = null;
                val_5 = val_3;
                val_3 = new Org.BouncyCastle.Crypto.Modes.Gcm.Tables8kGcmMultiplier();
            }
            
                this.cipher = c;
                this.multiplier = val_5;
                return;
            }
            
            System.ArgumentException val_5 = new System.ArgumentException(message:  "cipher required with a block size of " + 16 + ".");
        }
        public virtual string get_AlgorithmName()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.cipher.AlgorithmName + "/GCM"("/GCM");
        }
        public Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
        {
            return (Org.BouncyCastle.Crypto.IBlockCipher)this.cipher;
        }
        public virtual int GetBlockSize()
        {
            return 16;
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            Org.BouncyCastle.Crypto.ICipherParameters val_25;
            var val_26;
            string val_30;
            var val_32;
            System.Byte[] val_34;
            this.forEncryption = forEncryption;
            this.macBlock = 0;
            if(parameters == null)
            {
                goto label_5;
            }
            
            this.nonce = parameters.GetIV();
            this.initialAssociatedText = 0;
            this.macSize = 16;
            val_25 = parameters.Parameters;
            if(val_25 != null)
            {
                    val_25 = 0;
            }
            
            if(forEncryption != false)
            {
                    val_26 = 16;
            }
            else
            {
                    val_26 = this.macSize + 16;
            }
            
            this.bufBlock = new byte[0];
            if((this.nonce == null) || (this.nonce.Length <= 0))
            {
                goto label_15;
            }
            
            if( == null)
            {
                goto label_16;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            goto label_21;
            label_16:
            if(this.H != null)
            {
                goto label_22;
            }
            
            val_30 = "Key must be specified in initial init";
            goto label_43;
            label_21:
            this.cipher.Init(forEncryption:  true, parameters:  null);
            byte[] val_12 = new byte[16];
            this.H = val_12;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_32 = 0;
            int val_14 = this.cipher.ProcessBlock(inBuf:  val_12, inOff:  0, outBuf:  val_12, outOff:  0);
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_32 = 0;
            this.multiplier.Init(H:  this.H);
            this.exp = 0;
            label_22:
            this.J0 = new byte[16];
            if(this.nonce.Length == 12)
            {
                    val_34 = this.J0;
                System.Array.Copy(sourceArray:  this.nonce, sourceIndex:  0, destinationArray:  val_34, destinationIndex:  0, length:  this.nonce.Length);
                this.J0[1] = 1;
            }
            else
            {
                    this.gHASH(Y:  this.J0, b:  this.nonce, len:  this.nonce.Length);
                byte[] val_17 = new byte[16];
                val_34 = this.nonce;
                Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(n:  0, bs:  val_17, off:  8);
                this.gHASHBlock(Y:  this.J0, b:  val_17);
            }
            
            this.S = new byte[16];
            this.S_at = new byte[16];
            this.S_atPre = new byte[16];
            this.atBlock = new byte[16];
            this.atBlockPos = 0;
            this.atLength = 0;
            this.atLengthPre = 0;
            this.counter = Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.J0);
            this.blocksRemaining = -2;
            this.bufOff = -1;
            this.totalLength = 0;
            if(this.initialAssociatedText == null)
            {
                    return;
            }
            
            return;
            label_5:
            val_30 = "invalid parameters passed to GCM";
            goto label_43;
            label_15:
            System.ArgumentException val_23 = null;
            val_30 = "IV must be at least 1 byte";
            label_43:
            val_23 = new System.ArgumentException(message:  val_30);
            label_44:
            System.ArgumentException val_25 = new System.ArgumentException(message:  "Invalid value for MAC size: "("Invalid value for MAC size: ") + val_23);
            goto label_44;
        }
        public virtual byte[] GetMac()
        {
            return Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.macBlock);
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
        public virtual int GetUpdateOutputSize(int len)
        {
            var val_3 = this.bufOff + len;
            if(this.forEncryption != true)
            {
                    val_3 = val_3 - this.macSize;
                if()
            {
                    return 0;
            }
            
            }
            
            val_3 = (val_3 < 0) ? (val_3 + 15) : (val_3);
            return (int)val_3 & 4294967280;
        }
        public virtual void ProcessAadByte(byte input)
        {
            this.atBlock[this.atBlockPos] = input;
            int val_1 = this.atBlockPos;
            val_1 = val_1 + 1;
            this.atBlockPos = val_1;
            if(val_1 != 16)
            {
                    return;
            }
            
            this.gHASHBlock(Y:  this.S_at, b:  this.atBlock);
            ulong val_2 = this.atLength;
            this.atBlockPos = 0;
            val_2 = val_2 + 16;
            this.atLength = val_2;
        }
        public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
        {
            var val_2;
            int val_3;
            val_2 = inOff;
            if(len < 1)
            {
                    return;
            }
            
            int val_3 = len;
            do
            {
                this.atBlock[(long)this.atBlockPos] = inBytes[(long)val_2];
                val_3 = this.atBlockPos + 1;
                this.atBlockPos = val_3;
                if(val_3 == 16)
            {
                    this.gHASHBlock(Y:  this.S_at, b:  this.atBlock);
                ulong val_2 = this.atLength;
                val_3 = 0;
                this.atBlockPos = 0;
                val_2 = val_2 + 16;
                this.atLength = val_2;
            }
            
                val_3 = val_3 - 1;
                val_2 = val_2 + 1;
            }
            while(val_3 != 0);
        
        }
        private void InitCipher()
        {
            if(this.atLength != 0)
            {
                    System.Array.Copy(sourceArray:  this.S_at, sourceIndex:  0, destinationArray:  this.S_atPre, destinationIndex:  0, length:  16);
                this.atLengthPre = this.atLength;
            }
            
            if(this.atBlockPos <= 0)
            {
                goto label_1;
            }
            
            this.gHASHPartial(Y:  this.S_atPre, b:  this.atBlock, off:  0, len:  this.atBlockPos);
            ulong val_1 = this.atLengthPre;
            val_1 = val_1 + this.atBlockPos;
            this.atLengthPre = val_1;
            if(val_1 == 0)
            {
                    return;
            }
            
            label_3:
            System.Array.Copy(sourceArray:  this.S_atPre, sourceIndex:  0, destinationArray:  this.S, destinationIndex:  0, length:  16);
            return;
            label_1:
            if(this.atLengthPre != 0)
            {
                goto label_3;
            }
        
        }
        public virtual int ProcessByte(byte input, byte[] output, int outOff)
        {
            var val_2;
            this.bufBlock[this.bufOff] = input;
            int val_1 = this.bufOff + 1;
            this.bufOff = val_1;
            if(val_1 == this.bufBlock.Length)
            {
                    this.OutputBlock(output:  output, offset:  outOff);
                val_2 = 16;
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public virtual int ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
        {
            var val_5;
            var val_6;
            int val_7;
            var val_8;
            val_5 = len;
            val_6 = inOff;
            val_7 = input.Length;
            if((val_5 + val_6) > val_7)
            {
                goto label_2;
            }
            
            if(val_5 < 1)
            {
                goto label_3;
            }
            
            val_8 = 0;
            val_5 = val_5 - 1;
            goto label_4;
            label_10:
            val_7 = input.Length;
            val_6 = val_6 + 1;
            val_5 = val_5 - 1;
            label_4:
            this.bufBlock[this.bufOff] = input[(long)val_6];
            int val_2 = this.bufOff + 1;
            this.bufOff = val_2;
            if(val_2 == this.bufBlock.Length)
            {
                    this.OutputBlock(output:  output, offset:  val_8 + outOff);
                val_8 = val_8 + 16;
            }
            
            if(val_5 != 0)
            {
                goto label_10;
            }
            
            return (int)val_8;
            label_3:
            val_8 = 0;
            return (int)val_8;
            label_2:
            Org.BouncyCastle.Crypto.DataLengthException val_4 = new Org.BouncyCastle.Crypto.DataLengthException(message:  "Input buffer too short");
        }
        private void OutputBlock(byte[] output, int offset)
        {
            int val_1;
            Org.BouncyCastle.Crypto.Check.OutputLength(buf:  output, off:  offset, len:  16, msg:  "Output buffer too short");
            if(this.totalLength == 0)
            {
                    this.InitCipher();
            }
            
            this.gCTRBlock(block:  this.bufBlock, output:  output, outOff:  offset);
            if(this.forEncryption != false)
            {
                    val_1 = 0;
            }
            else
            {
                    System.Array.Copy(sourceArray:  this.bufBlock, sourceIndex:  16, destinationArray:  this.bufBlock, destinationIndex:  0, length:  this.macSize);
                val_1 = this.macSize;
            }
            
            this.bufOff = val_1;
        }
        public int DoFinal(byte[] output, int outOff)
        {
            System.Byte[] val_17;
            int val_18;
            int val_19;
            int val_20;
            System.Byte[] val_21;
            int val_22;
            string val_23;
            ulong val_24;
            Org.BouncyCastle.Crypto.Modes.Gcm.IGcmExponentiator val_25;
            System.Byte[] val_27;
            string val_31;
            val_17 = output;
            if(this.totalLength == 0)
            {
                    this.InitCipher();
            }
            
            val_18 = this.bufOff;
            val_19 = this.macSize;
            if(this.forEncryption == false)
            {
                goto label_2;
            }
            
            val_20 = val_19 + val_18;
            val_21 = val_17;
            val_22 = outOff;
            val_23 = "Output buffer too short";
            goto label_3;
            label_2:
            val_18 = val_18 - val_19;
            if()
            {
                goto label_4;
            }
            
            val_19 = "Output buffer too short";
            val_21 = val_17;
            val_22 = outOff;
            val_20 = val_18;
            val_23 = "Output buffer too short";
            label_3:
            Org.BouncyCastle.Crypto.Check.OutputLength(buf:  val_21, off:  val_22, len:  val_20, msg:  val_23);
            if(val_18 >= 1)
            {
                    val_20 = 0;
                val_23 = val_18;
                this.gCTRPartial(buf:  this.bufBlock, off:  0, len:  val_23, output:  val_17, outOff:  outOff);
            }
            
            ulong val_17 = this.atLength;
            val_24 = this.atLengthPre;
            val_17 = val_17 + this.atBlockPos;
            this.atLength = val_17;
            if(val_17 <= val_24)
            {
                goto label_6;
            }
            
            if(this.atBlockPos >= 1)
            {
                    val_20 = this.atBlock;
                val_23 = 0;
                this.gHASHPartial(Y:  this.S_at, b:  val_20, off:  0, len:  this.atBlockPos);
                val_24 = this.atLengthPre;
            }
            
            if(val_24 != 0)
            {
                    Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(x:  this.S_at, y:  this.S_atPre);
            }
            
            ulong val_18 = this.totalLength;
            val_18 = val_18 << 3;
            val_18 = val_18 + 127;
            byte[] val_2 = new byte[16];
            val_25 = this.exp;
            if(val_25 != null)
            {
                goto label_11;
            }
            
            Org.BouncyCastle.Crypto.Modes.Gcm.Tables1kGcmExponentiator val_3 = new Org.BouncyCastle.Crypto.Modes.Gcm.Tables1kGcmExponentiator();
            this.exp = val_3;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_20 = 0;
            goto label_16;
            label_6:
            val_27 = this.S;
            goto label_17;
            label_16:
            val_3.Init(x:  this.H);
            val_25 = this.exp;
            if(val_25 == null)
            {
                goto label_35;
            }
            
            label_11:
            label_35:
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_25.ExponentiateX(pow:  val_18 >> 7, output:  val_2);
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Multiply(x:  this.S_at, y:  val_2);
            val_27 = this;
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(x:  this.S, y:  this.S_at);
            label_17:
            byte[] val_6 = new byte[16];
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(n:  this.atLength << 3, bs:  val_6, off:  0);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(n:  this.totalLength << 3, bs:  val_6, off:  8);
            this.gHASHBlock(Y:  this.S, b:  val_6);
            byte[] val_9 = new byte[16];
            var val_21 = 0;
            val_21 = val_21 + 1;
            int val_11 = this.cipher.ProcessBlock(inBuf:  this.J0, inOff:  0, outBuf:  val_9, outOff:  0);
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(x:  val_9, y:  null);
            byte[] val_12 = new byte[0];
            this.macBlock = val_12;
            System.Array.Copy(sourceArray:  val_9, sourceIndex:  0, destinationArray:  val_12, destinationIndex:  0, length:  this.macSize);
            if(this.forEncryption == false)
            {
                goto label_32;
            }
            
            System.Array.Copy(sourceArray:  this.macBlock, sourceIndex:  0, destinationArray:  val_17, destinationIndex:  this.bufOff + outOff, length:  this.macSize);
            val_18 = this.macSize + val_18;
            goto label_33;
            label_32:
            byte[] val_14 = new byte[0];
            val_17 = val_14;
            System.Array.Copy(sourceArray:  this.bufBlock, sourceIndex:  val_18, destinationArray:  val_14, destinationIndex:  0, length:  this.macSize);
            if((Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a:  this.macBlock, b:  val_14)) == false)
            {
                goto label_34;
            }
            
            label_33:
            this.Reset(clearMac:  false);
            return val_18;
            label_4:
            val_31 = "data too short";
            goto label_36;
            label_34:
            val_31 = "mac check in GCM failed";
            label_36:
            null = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  val_31);
        }
        public virtual void Reset()
        {
            this.Reset(clearMac:  true);
        }
        private void Reset(bool clearMac)
        {
            var val_12 = 0;
            val_12 = val_12 + 1;
            this.cipher.Reset();
            this.S = new byte[16];
            this.S_at = new byte[16];
            this.S_atPre = new byte[16];
            this.atBlock = new byte[16];
            this.atBlockPos = 0;
            this.atLength = 0;
            this.atLengthPre = 0;
            this.counter = Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.J0);
            this.blocksRemaining = -2;
            this.bufOff = -1;
            this.totalLength = 0;
            if(this.bufBlock != null)
            {
                    Org.BouncyCastle.Utilities.Arrays.Fill(buf:  this.bufBlock, b:  0);
            }
            
            if(clearMac != false)
            {
                    this.macBlock = 0;
            }
            
            if(this.initialAssociatedText == null)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Org.BouncyCastle.Crypto.Modes.GcmBlockCipher).__il2cppRuntimeField_2A8;
        }
        private void gCTRBlock(byte[] block, byte[] output, int outOff)
        {
            System.Byte[] val_1 = this.GetNextCounterBlock();
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(x:  val_1, y:  block);
            System.Array.Copy(sourceArray:  val_1, sourceIndex:  0, destinationArray:  output, destinationIndex:  outOff, length:  16);
            this.gHASHBlock(Y:  this.S, b:  (this.forEncryption == true) ? (val_1) : block);
            ulong val_3 = this.totalLength;
            val_3 = val_3 + 16;
            this.totalLength = val_3;
        }
        private void gCTRPartial(byte[] buf, int off, int len, byte[] output, int outOff)
        {
            System.Byte[] val_1 = this.GetNextCounterBlock();
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(x:  val_1, y:  buf, yOff:  off, yLen:  len);
            System.Array.Copy(sourceArray:  val_1, sourceIndex:  0, destinationArray:  output, destinationIndex:  outOff, length:  len);
            this.gHASHPartial(Y:  this.S, b:  (this.forEncryption == true) ? (val_1) : buf, off:  0, len:  len);
            ulong val_3 = this.totalLength;
            val_3 = val_3 + len;
            this.totalLength = val_3;
        }
        private void gHASH(byte[] Y, byte[] b, int len)
        {
            var val_2;
            if(len < 1)
            {
                    return;
            }
            
            int val_2 = len;
            do
            {
                this.gHASHPartial(Y:  Y, b:  b, off:  0, len:  System.Math.Min(val1:  val_2, val2:  16));
                val_2 = 0 + 16;
                val_2 = val_2 - 16;
            }
            while(val_2 < len);
        
        }
        private void gHASHBlock(byte[] Y, byte[] b)
        {
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(x:  Y, y:  b);
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.multiplier.MultiplyH(x:  Y);
        }
        private void gHASHPartial(byte[] Y, byte[] b, int off, int len)
        {
            int val_2 = off;
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(x:  Y, y:  b, yOff:  val_2 = off, yLen:  len);
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = 1;
            this.multiplier.MultiplyH(x:  Y);
        }
        private byte[] GetNextCounterBlock()
        {
            uint val_5 = this.blocksRemaining;
            if(val_5 != 0)
            {
                    System.Byte[] val_7 = this.counter;
                val_5 = val_5 - 1;
                this.blocksRemaining = val_5;
                val_7 = val_7[1] + 1;
                this.counter[1] = val_7;
                val_7 = val_7 >> 8;
                val_7 = val_7 + this.counter[1];
                this.counter[1] = val_7;
                val_7 = val_7 >> 8;
                val_7 = val_7 + this.counter[1];
                this.counter[1] = val_7;
                val_7 = val_7 >> 8;
                val_7 = val_7 + this.counter[1];
                this.counter[1] = val_7;
                byte[] val_1 = new byte[16];
                var val_11 = 0;
                val_11 = val_11 + 1;
                int val_3 = this.cipher.ProcessBlock(inBuf:  this.counter, inOff:  0, outBuf:  val_1, outOff:  0);
                return (System.Byte[])val_1;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException(message:  "Attempt to process too many blocks");
        }
    
    }

}
