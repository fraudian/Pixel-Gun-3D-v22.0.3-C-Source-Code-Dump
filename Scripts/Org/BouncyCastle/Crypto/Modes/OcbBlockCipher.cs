using UnityEngine;

namespace Org.BouncyCastle.Crypto.Modes
{
    public class OcbBlockCipher : IAeadBlockCipher
    {
        // Fields
        private const int BLOCK_SIZE = 16;
        private readonly Org.BouncyCastle.Crypto.IBlockCipher hashCipher;
        private readonly Org.BouncyCastle.Crypto.IBlockCipher mainCipher;
        private bool forEncryption;
        private int macSize;
        private byte[] initialAssociatedText;
        private System.Collections.IList L;
        private byte[] L_Asterisk;
        private byte[] L_Dollar;
        private byte[] KtopInput;
        private byte[] Stretch;
        private byte[] OffsetMAIN_0;
        private byte[] hashBlock;
        private byte[] mainBlock;
        private int hashBlockPos;
        private int mainBlockPos;
        private long hashBlockCount;
        private long mainBlockCount;
        private byte[] OffsetHASH;
        private byte[] Sum;
        private byte[] OffsetMAIN;
        private byte[] Checksum;
        private byte[] macBlock;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public OcbBlockCipher(Org.BouncyCastle.Crypto.IBlockCipher hashCipher, Org.BouncyCastle.Crypto.IBlockCipher mainCipher)
        {
            string val_19;
            string val_20;
            string val_22;
            var val_23;
            var val_24;
            var val_25;
            this.Stretch = new byte[24];
            this.OffsetMAIN_0 = new byte[16];
            this.OffsetMAIN = new byte[16];
            if(hashCipher == null)
            {
                goto label_1;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            if(hashCipher.GetBlockSize() != 16)
            {
                goto label_6;
            }
            
            if(mainCipher == null)
            {
                goto label_7;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            if(mainCipher.GetBlockSize() != 16)
            {
                goto label_12;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            var val_21 = 0;
            val_21 = val_21 + 1;
            if((hashCipher.AlgorithmName.Equals(value:  mainCipher.AlgorithmName)) == false)
            {
                goto label_22;
            }
            
            this.hashCipher = hashCipher;
            this.mainCipher = mainCipher;
            return;
            label_1:
            val_19 = "hashCipher";
            goto label_23;
            label_6:
            val_20 = "must have a block size of " + 16;
            val_22 = "hashCipher";
            goto label_24;
            label_7:
            System.ArgumentNullException val_14 = null;
            val_19 = "mainCipher";
            label_23:
            val_23 = val_14;
            val_14 = new System.ArgumentNullException(paramName:  val_19);
            goto label_25;
            label_12:
            val_20 = "must have a block size of " + 16;
            System.ArgumentException val_16 = null;
            val_22 = "mainCipher";
            label_24:
            val_16 = new System.ArgumentException(message:  val_20, paramName:  val_22);
            val_24 = 1152921551406034096;
            val_25 = val_16;
            goto label_26;
            label_22:
            System.ArgumentException val_17 = null;
            val_23 = val_17;
            val_17 = new System.ArgumentException(message:  "\'hashCipher\' and \'mainCipher\' must be the same algorithm");
            label_25:
            val_24 = 1152921551406034096;
            val_25 = val_23;
            label_26:
        }
        public virtual Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
        {
            return (Org.BouncyCastle.Crypto.IBlockCipher)this.mainCipher;
        }
        public virtual string get_AlgorithmName()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.mainCipher.AlgorithmName + "/OCB"("/OCB");
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            bool val_38;
            var val_39;
            Org.BouncyCastle.Crypto.ICipherParameters val_40;
            var val_42;
            string val_45;
            var val_48;
            System.Collections.IList val_49;
            val_38 = this.forEncryption;
            this.forEncryption = forEncryption;
            this.macBlock = 0;
            if(parameters == null)
            {
                goto label_5;
            }
            
            val_39 = parameters.GetIV();
            this.initialAssociatedText = 0;
            this.macSize = 16;
            val_40 = parameters.Parameters;
            if(val_40 != null)
            {
                    val_40 = 0;
            }
            
            val_42 = 16;
            this.hashBlock = new byte[16];
            if(forEncryption != true)
            {
                    val_42 = this.macSize + 16;
            }
            
            this.mainBlock = new byte[0];
            if( == null)
            {
                    val_39 = new byte[0];
            }
            
            if(val_12.Length >= 16)
            {
                goto label_15;
            }
            
            if( == null)
            {
                goto label_16;
            }
            
            val_42 = 1152921505522446336;
            var val_39 = 0;
            val_39 = val_39 + 1;
            goto label_21;
            label_16:
            var val_13 = (val_38 == true) ? 1 : 0;
            val_13 = val_13 ^ forEncryption;
            if(val_13 == false)
            {
                goto label_22;
            }
            
            val_45 = "cannot change encrypting state without providing key.";
            goto label_51;
            label_21:
            this.hashCipher.Init(forEncryption:  true, parameters:  null);
            val_38 = this.mainCipher;
            var val_40 = 0;
            val_40 = val_40 + 1;
            val_38.Init(forEncryption:  forEncryption, parameters:  null);
            this.KtopInput = 0;
            label_22:
            byte[] val_17 = new byte[16];
            this.L_Asterisk = val_17;
            var val_41 = 0;
            val_41 = val_41 + 1;
            val_48 = 0;
            int val_19 = this.hashCipher.ProcessBlock(inBuf:  val_17, inOff:  0, outBuf:  val_17, outOff:  0);
            this.L_Dollar = Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.OCB_double(block:  this.L_Asterisk);
            val_49 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.L = val_49;
            var val_42 = 0;
            val_42 = val_42 + 1;
            val_48 = 2;
            int val_24 = val_49.Add(value:  Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.OCB_double(block:  this.L_Dollar));
            Org.BouncyCastle.Crypto.Modes.OcbBlockCipher val_43 = 1152921551407045127;
            var val_25 = (this < 0) ? (val_43) : (this);
            val_43 = val_25 & 4294967288;
            val_43 = this - val_43;
            int val_26 = val_25 >> 3;
            if(val_43 != null)
            {
                    val_43 = 8 - val_43;
                val_49 = (long)val_26;
                val_38 = val_43 & 31;
                do
            {
                var val_28 = val_26 + 32;
                val_28 = val_28 - 32;
                byte val_44 = this.Stretch[val_49];
                var val_29 = val_26 + 32;
                val_29 = val_29 - 31;
                var val_30 = 32 - 32;
                val_44 = (1152921505721910208 >> val_38) | (val_44 << (val_43 & 31));
                this.OffsetMAIN_0[0] = val_44;
                val_42 = 32 + 1;
            }
            while(val_42 != 48);
            
            }
            else
            {
                    System.Array.Copy(sourceArray:  this.Stretch, sourceIndex:  val_26, destinationArray:  this.OffsetMAIN_0, destinationIndex:  0, length:  16);
            }
            
            this.hashBlockCount = 0;
            this.mainBlockCount = 0;
            this.hashBlockPos = 0;
            this.mainBlockPos = 0;
            this.OffsetHASH = new byte[16];
            this.Sum = new byte[16];
            System.Array.Copy(sourceArray:  this.OffsetMAIN_0, sourceIndex:  0, destinationArray:  this.OffsetMAIN, destinationIndex:  0, length:  16);
            this.Checksum = new byte[16];
            if(this.initialAssociatedText == null)
            {
                    return;
            }
            
            return;
            label_5:
            val_45 = "invalid parameters passed to OCB";
            goto label_51;
            label_15:
            System.ArgumentException val_36 = null;
            val_45 = "IV must be no more than 15 bytes";
            label_51:
            val_36 = new System.ArgumentException(message:  val_45);
            label_52:
            System.ArgumentException val_38 = new System.ArgumentException(message:  "Invalid value for MAC size: "("Invalid value for MAC size: ") + val_36);
            goto label_52;
        }
        protected virtual int ProcessNonce(byte[] N)
        {
            int val_8;
            byte val_9;
            int val_10;
            byte val_11;
            int val_13;
            byte[] val_1 = new byte[16];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(N != null)
            {
                goto label_15;
            }
            
            label_16:
            label_15:
            System.Array.Copy(sourceArray:  N, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  val_1.Length - N.Length, length:  N.Length);
            val_8 = val_1.Length;
            val_9 = this.macSize << 4;
            if(val_8 == 0)
            {
                    val_8 = val_1.Length;
            }
            
            val_1[0] = val_9;
            int val_10 = N.Length;
            val_10 = 15 - val_10;
            byte val_11 = val_1[(long)val_10];
            val_11 = val_11 | 1;
            val_1[(long)val_10] = val_11;
            val_10 = val_1.Length;
            if(val_10 <= 15)
            {
                    val_10 = val_1.Length;
            }
            
            val_11 = val_1[1];
            if(val_10 <= 15)
            {
                    val_11 = val_1[1];
            }
            
            val_1[1] = val_11 & 192;
            if(this.KtopInput != null)
            {
                    if((Org.BouncyCastle.Utilities.Arrays.AreEqual(a:  val_1, b:  this.KtopInput)) == true)
            {
                    return (int)val_11 & 63;
            }
            
            }
            
            byte[] val_6 = new byte[16];
            this.KtopInput = val_1;
            var val_12 = 0;
            val_12 = val_12 + 1;
            goto label_14;
            label_1:
            if(N != null)
            {
                goto label_15;
            }
            
            goto label_16;
            label_14:
            int val_8 = this.hashCipher.ProcessBlock(inBuf:  val_1, inOff:  0, outBuf:  val_6, outOff:  0);
            System.Array.Copy(sourceArray:  val_6, sourceIndex:  0, destinationArray:  this.Stretch, destinationIndex:  0, length:  16);
            var val_15 = 0;
            do
            {
                val_9 = this.Stretch;
                val_13 = val_6.Length;
                if(val_15 >= val_13)
            {
                    val_13 = val_6.Length;
            }
            
                byte val_13 = val_6[val_15];
                var val_9 = val_15 + 1;
                val_9 = val_9 + 15;
                val_13 = val_6[val_15] ^ val_13;
                val_15 = val_9 - 15;
                val_9[val_15] = val_13;
            }
            while(val_15 != 8);
            
            return (int)val_11 & 63;
        }
        public virtual int GetBlockSize()
        {
            return 16;
        }
        public virtual byte[] GetMac()
        {
            return Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.macBlock);
        }
        public virtual int GetOutputSize(int len)
        {
            int val_3 = this.mainBlockPos;
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
            var val_3 = this.mainBlockPos + len;
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
            var val_8;
            System.Byte[] val_9;
            val_8 = this;
            this.hashBlock[this.hashBlockPos] = input;
            val_9 = this.hashBlock;
            int val_1 = this.hashBlockPos + 1;
            this.hashBlockPos = val_1;
            if(val_1 != this.hashBlock.Length)
            {
                    return;
            }
            
            val_8 = ???;
            val_9 = ???;
            goto typeof(Org.BouncyCastle.Crypto.Modes.OcbBlockCipher).__il2cppRuntimeField_338;
        }
        public virtual void ProcessAadBytes(byte[] input, int off, int len)
        {
            int val_2 = off;
            if(len < 1)
            {
                    return;
            }
            
            int val_3 = len;
            do
            {
                this.hashBlock[this.hashBlockPos] = input[(long)val_2];
                this.hashBlockPos = this.hashBlockPos + 1;
                val_3 = val_3 - 1;
                val_2 = val_2 + 1;
            }
            while(val_3 != 0);
        
        }
        public virtual int ProcessByte(byte input, byte[] output, int outOff)
        {
            var val_2;
            this.mainBlock[this.mainBlockPos] = input;
            int val_1 = this.mainBlockPos + 1;
            this.mainBlockPos = val_1;
            if(val_1 == this.mainBlock.Length)
            {
                    val_2 = 16;
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public virtual int ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
        {
            var val_3;
            var val_4;
            val_3 = inOff;
            val_4 = 0;
            if(len < 1)
            {
                    return (int)val_4;
            }
            
            int val_4 = len;
            do
            {
                this.mainBlock[this.mainBlockPos] = input[(long)val_3];
                int val_1 = this.mainBlockPos + 1;
                this.mainBlockPos = val_1;
                if(val_1 == this.mainBlock.Length)
            {
                    int val_2 = val_4 + outOff;
                val_4 = val_4 + 16;
            }
            
                val_4 = val_4 - 1;
                val_3 = val_3 + 1;
            }
            while(val_4 != 0);
            
            return (int)val_4;
        }
        public virtual int DoFinal(byte[] output, int outOff)
        {
            System.Array val_10;
            var val_11;
            System.Byte[] val_12;
            Org.BouncyCastle.Crypto.IBlockCipher val_13;
            int val_16;
            string val_18;
            if(this.forEncryption == false)
            {
                goto label_1;
            }
            
            val_10 = 0;
            goto label_2;
            label_1:
            int val_12 = this.mainBlockPos;
            if(val_12 < this.macSize)
            {
                goto label_3;
            }
            
            val_12 = val_12 - this.macSize;
            this.mainBlockPos = val_12;
            byte[] val_1 = new byte[0];
            val_10 = val_1;
            val_11 = 0;
            System.Array.Copy(sourceArray:  this.mainBlock, sourceIndex:  this.mainBlockPos, destinationArray:  val_1, destinationIndex:  0, length:  this.macSize);
            label_2:
            if(this.hashBlockPos >= 1)
            {
                    Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.OCB_extend(block:  this.hashBlock, pos:  this.hashBlockPos);
            }
            
            if(this.mainBlockPos <= 0)
            {
                goto label_5;
            }
            
            if(this.forEncryption != false)
            {
                    Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.OCB_extend(block:  this.mainBlock, pos:  this.mainBlockPos);
                Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.Checksum, val:  this.mainBlock);
            }
            
            val_12 = this;
            Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.OffsetMAIN, val:  this.L_Asterisk);
            byte[] val_2 = new byte[16];
            val_13 = this;
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_11;
            label_5:
            val_12 = this.OffsetMAIN;
            val_13 = this.hashCipher;
            goto label_13;
            label_11:
            int val_4 = this.hashCipher.ProcessBlock(inBuf:  this.OffsetMAIN, inOff:  0, outBuf:  val_2, outOff:  0);
            Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.mainBlock, val:  val_2);
            Org.BouncyCastle.Crypto.Check.OutputLength(buf:  output, off:  outOff, len:  this.mainBlockPos, msg:  "Output buffer too short");
            val_11 = 0;
            System.Array.Copy(sourceArray:  this.mainBlock, sourceIndex:  0, destinationArray:  output, destinationIndex:  outOff, length:  this.mainBlockPos);
            if(this.forEncryption != true)
            {
                    Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.OCB_extend(block:  this.mainBlock, pos:  this.mainBlockPos);
                Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.Checksum, val:  this.mainBlock);
            }
            
            label_13:
            Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.Checksum, val:  this.OffsetMAIN);
            Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.Checksum, val:  this.L_Dollar);
            var val_14 = 0;
            val_14 = val_14 + 1;
            int val_6 = this.hashCipher.ProcessBlock(inBuf:  this.Checksum, inOff:  0, outBuf:  this.Checksum, outOff:  0);
            Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.Checksum, val:  this.Sum);
            byte[] val_7 = new byte[0];
            this.macBlock = val_7;
            System.Array.Copy(sourceArray:  this.Checksum, sourceIndex:  0, destinationArray:  val_7, destinationIndex:  0, length:  this.macSize);
            val_16 = this.mainBlockPos;
            if(this.forEncryption != false)
            {
                    Org.BouncyCastle.Crypto.Check.OutputLength(buf:  output, off:  outOff, len:  this.macSize + val_16, msg:  "Output buffer too short");
                System.Array.Copy(sourceArray:  this.macBlock, sourceIndex:  0, destinationArray:  output, destinationIndex:  val_16 + outOff, length:  this.macSize);
                val_16 = this.macSize + val_16;
                return val_16;
            }
            
            if((Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a:  this.macBlock, b:  val_1)) == false)
            {
                goto label_21;
            }
            
            return val_16;
            label_3:
            val_18 = "data too short";
            goto label_22;
            label_21:
            val_18 = "mac check in OCB failed";
            label_22:
            null = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  val_18);
        }
        public virtual void Reset()
        {
            goto typeof(Org.BouncyCastle.Crypto.Modes.OcbBlockCipher).__il2cppRuntimeField_358;
        }
        protected virtual void Clear(byte[] bs)
        {
            if(bs == null)
            {
                    return;
            }
            
            System.Array.Clear(array:  bs, index:  0, length:  bs.Length);
        }
        protected virtual byte[] GetLSub(int n)
        {
            int val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            System.Byte[] val_13;
            var val_14;
            var val_15;
            var val_18;
            val_8 = n;
            goto label_1;
            label_24:
            var val_12 = mem[137150464];
            if((mem[137150464] + 286) == 0)
            {
                goto label_3;
            }
            
            var val_9 = mem[137150464] + 176;
            var val_10 = 0;
            val_9 = val_9 + 8;
            label_5:
            if(((mem[137150464] + 176 + 8) + -8) == X22)
            {
                goto label_4;
            }
            
            val_10 = val_10 + 1;
            val_9 = val_9 + 16;
            if(val_10 < (mem[137150464] + 286))
            {
                goto label_5;
            }
            
            label_3:
            val_9 = 1;
            goto label_6;
            label_4:
            var val_11 = val_9;
            val_11 = val_11 + 1;
            val_12 = val_12 + val_11;
            val_10 = val_12 + 296;
            label_6:
            var val_15 = mem[137150464];
            if((mem[137150464] + 286) == 0)
            {
                goto label_8;
            }
            
            var val_13 = mem[137150464] + 176;
            var val_14 = 0;
            val_13 = val_13 + 8;
            label_10:
            if(((mem[137150464] + 176 + 8) + -8) == null)
            {
                goto label_9;
            }
            
            val_14 = val_14 + 1;
            val_13 = val_13 + 16;
            if(val_14 < (mem[137150464] + 286))
            {
                goto label_10;
            }
            
            label_8:
            val_9 = 0;
            goto label_11;
            label_9:
            val_15 = val_15 + (((mem[137150464] + 176 + 8)) << 4);
            val_11 = val_15 + 296;
            label_11:
            val_12 = public System.Object System.Collections.IList::get_Item(int index);
            val_13 = 137150464;
            object val_1 = Item[137150463];
            if(val_1 != null)
            {
                    val_13 = val_1;
                if(val_13 == null)
            {
                    val_12 = 0;
                val_13 = 0;
            }
            
            }
            
            var val_19 = mem[137150464];
            if((mem[137150464] + 286) == 0)
            {
                goto label_15;
            }
            
            var val_16 = mem[137150464] + 176;
            var val_17 = 0;
            val_16 = val_16 + 8;
            label_17:
            if(((mem[137150464] + 176 + 8) + -8) == null)
            {
                goto label_16;
            }
            
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            if(val_17 < (mem[137150464] + 286))
            {
                goto label_17;
            }
            
            label_15:
            val_12 = 2;
            goto label_18;
            label_16:
            var val_18 = val_16;
            val_18 = val_18 + 2;
            val_19 = val_19 + val_18;
            val_14 = val_19 + 296;
            label_18:
            val_15 = public System.Int32 System.Collections.IList::Add(object value);
            int val_4 = Add(value:  Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.OCB_double(block:  val_13));
            label_1:
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_15 = 1;
            if(this.L.Count <= val_8)
            {
                goto label_24;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_15 = 0;
            val_18 = this.L;
            object val_8 = val_18.Item[val_8];
            if(val_8 == null)
            {
                    return (System.Byte[])val_18;
            }
            
            val_18 = val_8;
            val_8 = null;
            if(val_18 != null)
            {
                    return (System.Byte[])val_18;
            }
            
            val_18 = 0;
            return (System.Byte[])val_18;
        }
        protected virtual void ProcessHashBlock()
        {
            long val_1 = this.hashBlockCount;
            val_1 = val_1 + 1;
            this.hashBlockCount = val_1;
            if(val_1 == 0)
            {
                goto label_0;
            }
            
            var val_2 = 0;
            if((val_1 & 1) != 0)
            {
                goto label_3;
            }
            
            do
            {
                val_1 = val_1 >> 1;
                val_2 = val_2 + 1;
            }
            while((val_1 & 1) == 0);
            
            goto label_3;
            label_0:
            label_3:
            this.hashBlockPos = 0;
        }
        protected virtual void ProcessMainBlock(byte[] output, int outOff)
        {
            Org.BouncyCastle.Crypto.Check.DataLength(buf:  output, off:  outOff, len:  16, msg:  "Output buffer too short");
            if(this.forEncryption != false)
            {
                    Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.Checksum, val:  this.mainBlock);
                this.mainBlockPos = 0;
            }
            
            long val_3 = this.mainBlockCount;
            val_3 = val_3 + 1;
            this.mainBlockCount = val_3;
            if(val_3 == 0)
            {
                goto label_2;
            }
            
            var val_4 = 0;
            if((val_3 & 1) != 0)
            {
                goto label_5;
            }
            
            do
            {
                val_3 = val_3 >> 1;
                val_4 = val_4 + 1;
            }
            while((val_3 & 1) == 0);
            
            goto label_5;
            label_2:
            label_5:
            Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.OffsetMAIN, val:  this);
            Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.mainBlock, val:  this.OffsetMAIN);
            var val_5 = 0;
            val_5 = val_5 + 1;
            int val_2 = this.mainCipher.ProcessBlock(inBuf:  this.mainBlock, inOff:  0, outBuf:  this.mainBlock, outOff:  0);
            Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.mainBlock, val:  this.OffsetMAIN);
            System.Array.Copy(sourceArray:  this.mainBlock, sourceIndex:  0, destinationArray:  output, destinationIndex:  outOff, length:  16);
            if(this.forEncryption == true)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.Checksum, val:  this.mainBlock);
            System.Array.Copy(sourceArray:  this.mainBlock, sourceIndex:  16, destinationArray:  this.mainBlock, destinationIndex:  0, length:  this.macSize);
            this.mainBlockPos = this.macSize;
        }
        protected virtual void Reset(bool clearMac)
        {
            var val_9;
            Org.BouncyCastle.Crypto.IBlockCipher val_11;
            val_9 = this;
            var val_9 = 0;
            val_9 = val_9 + 1;
            this.hashCipher.Reset();
            val_11 = this.mainCipher;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_11.Reset();
            this.hashBlockCount = 0;
            this.mainBlockCount = 0;
            this.hashBlockPos = 0;
            this.mainBlockPos = 0;
            System.Array.Copy(sourceArray:  this.OffsetMAIN_0, sourceIndex:  0, destinationArray:  this.OffsetMAIN, destinationIndex:  0, length:  16);
            if(clearMac != false)
            {
                    this.macBlock = 0;
            }
            
            if(this.initialAssociatedText == null)
            {
                    return;
            }
            
            val_9 = ???;
            val_11 = ???;
            goto typeof(Org.BouncyCastle.Crypto.Modes.OcbBlockCipher).__il2cppRuntimeField_2C8;
        }
        protected virtual void UpdateHASH(byte[] LSub)
        {
            Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.OffsetHASH, val:  LSub);
            Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.hashBlock, val:  this.OffsetHASH);
            var val_3 = 0;
            val_3 = val_3 + 1;
            int val_2 = this.hashCipher.ProcessBlock(inBuf:  this.hashBlock, inOff:  0, outBuf:  this.hashBlock, outOff:  0);
            Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.Xor(block:  this.Sum, val:  this.hashBlock);
        }
        protected static byte[] OCB_double(byte[] block)
        {
            byte[] val_1 = new byte[16];
            byte val_3 = val_1[1];
            var val_4 = 1;
            val_4 = val_4 - (Org.BouncyCastle.Crypto.Modes.OcbBlockCipher.ShiftLeft(block:  block, output:  val_1));
            val_4 = 135 >> val_4;
            val_3 = val_4 ^ val_3;
            val_1[1] = val_3;
            return (System.Byte[])val_1;
        }
        protected static void OCB_extend(byte[] block, int pos)
        {
            int val_1 = pos;
            val_1 = val_1 + 1;
            block[(long)val_1] = 128;
            if(val_1 > 15)
            {
                    return;
            }
            
            do
            {
                val_1 = val_1 + 1;
                mem2[0] = 0;
            }
            while(val_1 != 16);
        
        }
        protected static int OCB_ntz(long x)
        {
            var val_1;
            if(x != 0)
            {
                    val_1 = 0;
                if((x & 1) != 0)
            {
                    return (int)val_1;
            }
            
                do
            {
                x = x >> 1;
                val_1 = val_1 + 1;
            }
            while((x & 1) == 0);
            
                return (int)val_1;
            }
            
            val_1 = 64;
            return (int)val_1;
        }
        protected static int ShiftLeft(byte[] block, byte[] output)
        {
            byte val_4 = 0;
            do
            {
                byte val_3 = block[1];
                val_4 = val_4 | (val_3 << 1);
                output[1] = val_4;
                var val_2 = 47 - 1;
            }
            while(15 > 0);
            
            return (int)val_3 >> 7;
        }
        protected static void Xor(byte[] block, byte[] val)
        {
            do
            {
                byte val_3 = val[1];
                val_3 = val_3 ^ block[1];
                block[1] = val_3;
                var val_1 = 47 - 1;
            }
            while(15 > 0);
        
        }
    
    }

}
