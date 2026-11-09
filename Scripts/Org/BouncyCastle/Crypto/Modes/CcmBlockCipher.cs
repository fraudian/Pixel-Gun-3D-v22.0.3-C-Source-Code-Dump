using UnityEngine;

namespace Org.BouncyCastle.Crypto.Modes
{
    public class CcmBlockCipher : IAeadBlockCipher
    {
        // Fields
        private static readonly int BlockSize;
        private readonly Org.BouncyCastle.Crypto.IBlockCipher cipher;
        private readonly byte[] macBlock;
        private bool forEncryption;
        private byte[] nonce;
        private byte[] initialAssociatedText;
        private int macSize;
        private Org.BouncyCastle.Crypto.ICipherParameters keyParam;
        private readonly System.IO.MemoryStream associatedText;
        private readonly System.IO.MemoryStream data;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public CcmBlockCipher(Org.BouncyCastle.Crypto.IBlockCipher cipher)
        {
            var val_7;
            int val_9;
            this.associatedText = new System.IO.MemoryStream();
            this.data = new System.IO.MemoryStream();
            this.cipher = cipher;
            val_7 = null;
            val_7 = null;
            this.macBlock = new byte[0];
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize;
            if(cipher.GetBlockSize() == val_9)
            {
                    return;
            }
            
            val_9 = Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize;
            System.ArgumentException val_7 = new System.ArgumentException(message:  "cipher required with a block size of " + val_9 + ".");
        }
        public virtual Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
        {
            return (Org.BouncyCastle.Crypto.IBlockCipher)this.cipher;
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            string val_10;
            this.forEncryption = forEncryption;
            if(parameters == null)
            {
                goto label_5;
            }
            
            this.nonce = parameters.GetIV();
            this.initialAssociatedText = 0;
            int val_4 = (this.macBlock.Length < 0) ? (this.macBlock.Length + 1) : this.macBlock.Length;
            val_4 = val_4 >> 1;
            this.macSize = val_4;
            Org.BouncyCastle.Crypto.ICipherParameters val_5 = parameters.Parameters;
            if(val_5 != null)
            {
                    this.keyParam = val_5;
            }
            
            if(this.nonce == null)
            {
                goto label_9;
            }
            
            int val_9 = this.nonce.Length;
            val_9 = val_9 - 7;
            if(val_9 >= 7)
            {
                goto label_9;
            }
            
            return;
            label_5:
            val_10 = "invalid parameters passed to CCM";
            goto label_12;
            label_9:
            val_10 = "nonce must have length from 7 to 13 octets";
            label_12:
            null = new System.ArgumentException(message:  val_10);
        }
        public virtual string get_AlgorithmName()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.cipher.AlgorithmName + "/CCM"("/CCM");
        }
        public virtual int GetBlockSize()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.GetBlockSize();
        }
        public virtual void ProcessAadByte(byte input)
        {
            if(this.associatedText == null)
            {
                
            }
        
        }
        public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
        {
            if(this.associatedText == null)
            {
                
            }
        
        }
        public virtual int ProcessByte(byte input, byte[] outBytes, int outOff)
        {
            if(this.data != null)
            {
                    return 0;
            }
            
            return 0;
        }
        public virtual int ProcessBytes(byte[] inBytes, int inOff, int inLen, byte[] outBytes, int outOff)
        {
            Org.BouncyCastle.Crypto.Check.DataLength(buf:  inBytes, off:  inOff, len:  inLen, msg:  "Input buffer too short");
            if(this.data != null)
            {
                    return 0;
            }
            
            return 0;
        }
        public virtual int DoFinal(byte[] outBytes, int outOff)
        {
            if(this.data != null)
            {
                    return (int)this;
            }
            
            return (int)this;
        }
        public virtual void Reset()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.cipher.Reset();
            if(this.data == null)
            {
                
            }
        
        }
        public virtual byte[] GetMac()
        {
            return Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  this.macBlock, from:  0, to:  this.macSize);
        }
        public virtual int GetUpdateOutputSize(int len)
        {
            return 0;
        }
        public virtual int GetOutputSize(int len)
        {
            var val_2;
            System.IO.MemoryStream val_3 = this.data;
            int val_2 = this.macSize;
            System.IO.MemoryStream val_1 = val_3 + len;
            if(this.forEncryption != false)
            {
                    val_2 = val_2 + val_1;
                return (int)val_3;
            }
            
            val_2 = val_1 - val_2;
            val_3 = () ? 0 : (val_2);
            return (int)val_3;
        }
        public virtual byte[] ProcessPacket(byte[] input, int inOff, int inLen)
        {
            var val_3;
            if(this.forEncryption != false)
            {
                    val_3 = this.macSize + inLen;
                return (System.Byte[])new byte[0];
            }
            
            if(this.macSize <= inLen)
            {
                    val_3 = inLen - this.macSize;
                return (System.Byte[])new byte[0];
            }
            
            Org.BouncyCastle.Crypto.InvalidCipherTextException val_2 = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  "data too short");
        }
        public virtual int ProcessPacket(byte[] input, int inOff, int inLen, byte[] output, int outOff)
        {
            int val_31;
            var val_32;
            var val_34;
            System.Byte[] val_35;
            int val_38;
            var val_39;
            int val_41;
            System.Array val_42;
            int val_43;
            int val_45;
            int val_46;
            var val_47;
            int val_49;
            string val_52;
            var val_53;
            string val_55;
            int val_40 = inLen;
            val_31 = inOff;
            if(this.keyParam == null)
            {
                goto label_1;
            }
            
            int val_37 = this.nonce.Length;
            int val_1 = 15 - val_37;
            if(val_1 > 3)
            {
                goto label_3;
            }
            
            val_37 = 1 << val_37;
            if(val_37 <= val_40)
            {
                goto label_4;
            }
            
            label_3:
            val_32 = null;
            val_32 = null;
            byte[] val_2 = new byte[0];
            val_1 = (val_1 + 7) & 7;
            val_2[0] = val_1;
            this.nonce.CopyTo(array:  val_2, index:  1);
            Org.BouncyCastle.Crypto.Modes.SicBlockCipher val_4 = new Org.BouncyCastle.Crypto.Modes.SicBlockCipher(cipher:  this.cipher);
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_4.Init(forEncryption:  (this.forEncryption == true) ? 1 : 0, parameters:  new Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(parameters:  this.keyParam, iv:  val_2));
            if(this.forEncryption == false)
            {
                goto label_15;
            }
            
            Org.BouncyCastle.Crypto.Check.OutputLength(buf:  output, off:  outOff, len:  this.macSize + val_40, msg:  "Output buffer too short.");
            int val_9 = this.CalculateMac(data:  input, dataOff:  val_31, dataLen:  val_40, macBlock:  this.macBlock);
            val_34 = null;
            val_34 = null;
            byte[] val_10 = new byte[0];
            val_35 = val_10;
            var val_39 = 0;
            val_39 = val_39 + 1;
            goto label_22;
            label_15:
            if(this.macSize > val_40)
            {
                goto label_23;
            }
            
            int val_11 = val_40 - this.macSize;
            Org.BouncyCastle.Crypto.Check.OutputLength(buf:  output, off:  outOff, len:  val_11, msg:  "Output buffer too short.");
            val_40 = val_11 + val_31;
            System.Array.Copy(sourceArray:  input, sourceIndex:  val_40, destinationArray:  this.macBlock, destinationIndex:  0, length:  this.macSize);
            var val_41 = 0;
            val_41 = val_41 + 1;
            goto label_28;
            label_22:
            int val_13 = val_4.ProcessBlock(inBuf:  this.macBlock, inOff:  0, outBuf:  val_10, outOff:  0);
            val_38 = outOff;
            int val_14 = val_40 + val_31;
            val_39 = null;
            goto label_29;
            label_39:
            var val_42 = 0;
            val_42 = val_42 + 1;
            int val_16 = val_4.ProcessBlock(inBuf:  input, inOff:  val_31, outBuf:  output, outOff:  val_38);
            val_39 = null;
            val_39 = null;
            val_38 = Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize + val_38;
            val_31 = Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize + val_31;
            label_29:
            val_39 = null;
            val_41 = Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize;
            if(val_31 < (val_14 - val_41))
            {
                goto label_39;
            }
            
            val_41 = Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize;
            byte[] val_18 = new byte[0];
            val_42 = val_18;
            val_14 = val_14 - val_31;
            System.Array.Copy(sourceArray:  input, sourceIndex:  val_31, destinationArray:  val_18, destinationIndex:  0, length:  val_14);
            val_43 = val_11;
            var val_43 = 0;
            val_43 = val_43 + 1;
            int val_20 = val_4.ProcessBlock(inBuf:  val_18, inOff:  0, outBuf:  val_18, outOff:  0);
            System.Array.Copy(sourceArray:  val_18, sourceIndex:  0, destinationArray:  output, destinationIndex:  val_38, length:  val_14);
            System.Array.Copy(sourceArray:  val_10, sourceIndex:  0, destinationArray:  output, destinationIndex:  outOff + val_40, length:  this.macSize);
            return val_43;
            label_28:
            int val_23 = val_4.ProcessBlock(inBuf:  this.macBlock, inOff:  0, outBuf:  this.macBlock, outOff:  0);
            val_45 = this.macSize;
            goto label_48;
            label_52:
            val_45 = val_45 + 1;
            this.macBlock[(long)val_45] = 0;
            label_48:
            if(val_45 != this.macBlock.Length)
            {
                goto label_52;
            }
            
            val_42 = outOff;
            val_46 = val_31;
            val_47 = null;
            val_35 = val_42;
            goto label_53;
            label_63:
            var val_44 = 0;
            val_44 = val_44 + 1;
            int val_25 = val_4.ProcessBlock(inBuf:  input, inOff:  val_46, outBuf:  output, outOff:  val_35);
            val_47 = null;
            val_47 = null;
            val_35 = Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize + val_35;
            val_46 = Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize + val_46;
            label_53:
            val_47 = null;
            val_49 = Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize;
            if(val_46 < (val_40 - val_49))
            {
                goto label_63;
            }
            
            val_49 = Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize;
            byte[] val_27 = new byte[0];
            val_43 = val_11;
            int val_29 = (val_31 - val_46) + val_43;
            System.Array.Copy(sourceArray:  input, sourceIndex:  val_46, destinationArray:  val_27, destinationIndex:  0, length:  val_29);
            var val_45 = 0;
            val_45 = val_45 + 1;
            int val_31 = val_4.ProcessBlock(inBuf:  val_27, inOff:  0, outBuf:  val_27, outOff:  0);
            System.Array.Copy(sourceArray:  val_27, sourceIndex:  0, destinationArray:  output, destinationIndex:  val_35, length:  val_29);
            byte[] val_32 = new byte[0];
            int val_33 = this.CalculateMac(data:  output, dataOff:  val_42, dataLen:  val_43, macBlock:  val_32);
            if((Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a:  this.macBlock, b:  val_32)) == false)
            {
                goto label_71;
            }
            
            return val_43;
            label_1:
            val_52 = "CCM cipher unitialized.";
            goto label_72;
            label_4:
            System.InvalidOperationException val_35 = null;
            val_52 = "CCM packet too large for choice of q.";
            label_72:
            val_53 = val_35;
            val_35 = new System.InvalidOperationException(message:  val_52);
            goto label_73;
            label_23:
            val_55 = "data too short";
            goto label_74;
            label_71:
            Org.BouncyCastle.Crypto.InvalidCipherTextException val_36 = null;
            val_55 = "mac check in CCM failed";
            label_74:
            val_53 = val_36;
            val_36 = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  val_55);
            label_73:
        }
        private int CalculateMac(byte[] data, int dataOff, int dataLen, byte[] macBlock)
        {
            int val_31;
            System.Array val_33;
            var val_34;
            int val_36;
            var val_38;
            var val_39;
            var val_40;
            var val_42;
            var val_44;
            var val_46;
            var val_48;
            var val_50;
            var val_52;
            var val_54;
            byte val_55;
            var val_56;
            var val_57;
            Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac val_1 = null;
            val_31 = this.macSize << 3;
            val_1 = new Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac(cipher:  this.cipher, macSizeInBits:  val_31, padding:  0);
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_31 = 0;
            val_1.Init(parameters:  this.keyParam);
            byte[] val_3 = new byte[16];
            val_33 = val_3;
            if(this.GetAssociatedTextLength() >= 1)
            {
                    byte val_34 = val_33[0];
                val_34 = 0;
                val_34 = val_34 | 64;
                val_33[0] = val_34;
            }
            else
            {
                    if(val_33 != null)
            {
                    val_34 = 0;
            }
            else
            {
                    val_34 = 1;
            }
            
            }
            
            var val_36 = 0;
            val_36 = val_36 + 1;
            int val_6 = val_1.GetMacSize();
            int val_7 = val_6 - 2;
            byte val_9 = (val_7 < 0) ? (val_6 - 1) : (val_7);
            val_9 = val_9 << 2;
            val_9 = val_9 & 56;
            val_9 = val_9 | val_33[0];
            val_33[0] = val_9;
            int val_38 = this.nonce.Length;
            val_38 = 6 - val_38;
            val_38 = val_38 & 7;
            val_38 = val_38 | val_33[0];
            val_33[0] = val_38;
            System.Array.Copy(sourceArray:  this.nonce, sourceIndex:  0, destinationArray:  val_3, destinationIndex:  1, length:  this.nonce.Length);
            if(dataLen >= 1)
            {
                    var val_40 = 0;
                do
            {
                int val_39 = val_3.Length;
                val_39 = val_40 + val_39;
                val_33[(long)val_39] = dataLen;
                val_36 = dataLen >> 8;
                val_40 = val_40 - 1;
            }
            while(val_36 != 0);
            
            }
            
            var val_41 = 0;
            val_41 = val_41 + 1;
            val_38 = public System.Void Org.BouncyCastle.Crypto.IMac::BlockUpdate(byte[] input, int inOff, int len);
            val_39 = 0;
            val_1.BlockUpdate(input:  val_3, inOff:  0, len:  val_3.Length);
            if(this.GetAssociatedTextLength() < 1)
            {
                goto label_88;
            }
            
            val_33 = this.GetAssociatedTextLength();
            if(val_33 <= 65279)
            {
                goto label_33;
            }
            
            var val_42 = 0;
            val_42 = val_42 + 1;
            val_40 = 3;
            goto label_37;
            label_33:
            var val_43 = 0;
            val_43 = val_43 + 1;
            val_42 = 3;
            goto label_41;
            label_37:
            val_44 = public System.Void Org.BouncyCastle.Crypto.IMac::Update(byte input);
            val_1.Update(input:  255);
            var val_44 = 0;
            val_44 = val_44 + 1;
            val_44 = 3;
            val_46 = public System.Void Org.BouncyCastle.Crypto.IMac::Update(byte input);
            val_1.Update(input:  254);
            var val_45 = 0;
            val_45 = val_45 + 1;
            val_46 = 3;
            val_48 = public System.Void Org.BouncyCastle.Crypto.IMac::Update(byte input);
            val_1.Update(input:  val_33 >> 24);
            var val_46 = 0;
            val_46 = val_46 + 1;
            val_48 = 3;
            val_50 = public System.Void Org.BouncyCastle.Crypto.IMac::Update(byte input);
            val_1.Update(input:  val_33 >> 16);
            var val_47 = 0;
            val_47 = val_47 + 1;
            val_50 = 3;
            val_52 = public System.Void Org.BouncyCastle.Crypto.IMac::Update(byte input);
            val_1.Update(input:  val_33 >> 8);
            var val_48 = 0;
            val_48 = val_48 + 1;
            val_52 = 3;
            val_54 = public System.Void Org.BouncyCastle.Crypto.IMac::Update(byte input);
            val_55 = val_33;
            val_1.Update(input:  val_55);
            val_56 = 6;
            goto label_67;
            label_41:
            val_57 = public System.Void Org.BouncyCastle.Crypto.IMac::Update(byte input);
            val_1.Update(input:  val_33 >> 8);
            var val_49 = 0;
            val_49 = val_49 + 1;
            val_57 = 3;
            val_54 = public System.Void Org.BouncyCastle.Crypto.IMac::Update(byte input);
            val_55 = val_33;
            val_1.Update(input:  val_55);
            val_56 = 2;
            label_67:
            if(this.initialAssociatedText != null)
            {
                    val_36 = this.initialAssociatedText.Length;
                var val_50 = 0;
                val_50 = val_50 + 1;
                val_38 = public System.Void Org.BouncyCastle.Crypto.IMac::BlockUpdate(byte[] input, int inOff, int len);
                val_55 = this.initialAssociatedText;
                val_54 = 0;
                val_1.BlockUpdate(input:  val_55, inOff:  0, len:  val_36);
            }
            
            if(this.associatedText >= 1)
            {
                    var val_51 = 0;
                val_51 = val_51 + 1;
                val_38 = public System.Void Org.BouncyCastle.Crypto.IMac::BlockUpdate(byte[] input, int inOff, int len);
                val_54 = 0;
                val_1.BlockUpdate(input:  this.associatedText, inOff:  0, len:  this.associatedText);
            }
            
            int val_27 = val_56 + val_33;
            var val_29 = (val_27 < 0) ? (val_27 + 15) : (val_27);
            val_29 = val_29 & 4294967280;
            val_34 = val_27 - val_29;
            if(val_34 != 0)
            {
                    do
            {
                var val_52 = 0;
                val_52 = val_52 + 1;
                val_54 = 3;
                val_1.Update(input:  0);
                val_34 = val_34 + 1;
            }
            while(val_34 != 16);
            
            }
            
            label_88:
            var val_53 = 0;
            val_53 = val_53 + 1;
            val_1.BlockUpdate(input:  data, inOff:  dataOff, len:  dataLen);
            var val_54 = 0;
            val_54 = val_54 + 1;
            return val_1.DoFinal(output:  macBlock, outOff:  0);
        }
        private int GetAssociatedTextLength()
        {
            System.Byte[] val_1;
            System.IO.MemoryStream val_1 = this.associatedText;
            val_1 = this.initialAssociatedText;
            if(val_1 != null)
            {
                    val_1 = this.initialAssociatedText.Length;
            }
            
            val_1 = val_1 + val_1;
            return (int)val_1;
        }
        private bool HasAssociatedText()
        {
            return (bool)(this.GetAssociatedTextLength() > 0) ? 1 : 0;
        }
        private static CcmBlockCipher()
        {
            Org.BouncyCastle.Crypto.Modes.CcmBlockCipher.BlockSize = 16;
        }
    
    }

}
