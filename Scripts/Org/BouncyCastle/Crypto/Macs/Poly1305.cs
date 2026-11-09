using UnityEngine;

namespace Org.BouncyCastle.Crypto.Macs
{
    public class Poly1305 : IMac
    {
        // Fields
        private const int BlockSize = 16;
        private readonly Org.BouncyCastle.Crypto.IBlockCipher cipher;
        private readonly byte[] singleByte;
        private uint r0;
        private uint r1;
        private uint r2;
        private uint r3;
        private uint r4;
        private uint s1;
        private uint s2;
        private uint s3;
        private uint s4;
        private uint k0;
        private uint k1;
        private uint k2;
        private uint k3;
        private byte[] currentBlock;
        private int currentBlockOffset;
        private uint h0;
        private uint h1;
        private uint h2;
        private uint h3;
        private uint h4;
        
        // Properties
        public string AlgorithmName { get; }
        
        // Methods
        public Poly1305()
        {
            this.singleByte = new byte[1];
            this.currentBlock = new byte[16];
            this.cipher = 0;
        }
        public Poly1305(Org.BouncyCastle.Crypto.IBlockCipher cipher)
        {
            this.singleByte = new byte[1];
            this.currentBlock = new byte[16];
            var val_6 = 0;
            val_6 = val_6 + 1;
            if(cipher.GetBlockSize() == 16)
            {
                    this.cipher = cipher;
                return;
            }
            
            System.ArgumentException val_5 = new System.ArgumentException(message:  "Poly1305 requires a 128 bit block cipher.");
        }
        public void Init(Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            var val_6;
            System.Byte[] val_7;
            var val_8;
            val_6 = parameters;
            if(this.cipher == null)
            {
                goto label_1;
            }
            
            if(val_6 == null)
            {
                goto label_4;
            }
            
            val_7 = val_6.GetIV();
            val_6 = val_6.Parameters;
            if(val_6 != null)
            {
                goto label_5;
            }
            
            goto label_9;
            label_1:
            val_7 = 0;
            if(val_6 == null)
            {
                goto label_9;
            }
            
            label_5:
            this.SetKey(key:  val_6.GetKey(), nonce:  val_7);
            this.h1 = 0;
            this.h2 = 0;
            this.h3 = 0;
            this.h4 = 0;
            this.currentBlockOffset = 0;
            this.h0 = 0;
            return;
            label_9:
            System.ArgumentException val_4 = null;
            val_8 = val_4;
            val_4 = new System.ArgumentException(message:  "Poly1305 requires a key.");
            goto label_10;
            label_4:
            System.ArgumentException val_5 = null;
            val_8 = val_5;
            val_5 = new System.ArgumentException(message:  "Poly1305 requires an IV when used with a block cipher.", paramName:  "parameters");
            label_10:
        }
        private void SetKey(byte[] key, byte[] nonce)
        {
            System.Byte[] val_22;
            System.Byte[] val_23;
            Org.BouncyCastle.Crypto.IBlockCipher val_24;
            var val_26;
            string val_29;
            val_22 = key;
            if(key.Length != 32)
            {
                goto label_2;
            }
            
            if(this.cipher != null)
            {
                    if((nonce == null) || (nonce.Length != 16))
            {
                goto label_5;
            }
            
            }
            
            val_23 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  val_22, off:  0);
            val_24 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  val_22, off:  4);
            uint val_3 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  val_22, off:  8);
            uint val_5 = W9 & 67108611;
            uint val_6 = W11 & 67092735;
            uint val_7 = W12 & 66076671;
            this.r0 = val_23 & 67108863;
            this.r1 = val_5;
            this.r2 = val_6;
            this.r3 = val_7;
            this.r4 = (uint)((Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  val_22, off:  12)) >> 8) & 1048575;
            this.s1 = val_5 + (val_5 << 2);
            this.s2 = val_6 + (val_6 << 2);
            this.s3 = val_7 + (val_7 << 2);
            this.s4 = ((uint)((Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  val_22, off:  12)) >> 8) & 1048575) + (((uint)((Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  val_22, off:  12)) >> 8) & 1048575) << 2);
            if(this.cipher == null)
            {
                goto label_6;
            }
            
            byte[] val_13 = new byte[16];
            val_24 = this.cipher;
            val_23 = val_13;
            var val_26 = 0;
            val_26 = val_26 + 1;
            goto label_11;
            label_6:
            val_26 = 16;
            goto label_12;
            label_11:
            val_24.Init(forEncryption:  true, parameters:  new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_22, keyOff:  16, keyLen:  16));
            var val_27 = 0;
            val_27 = val_27 + 1;
            int val_17 = this.cipher.ProcessBlock(inBuf:  nonce, inOff:  0, outBuf:  val_13, outOff:  0);
            val_26 = 0;
            val_22 = val_23;
            label_12:
            this.k0 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  val_13, off:  0);
            this.k1 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  val_13, off:  val_26 | 4);
            this.k2 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  val_13, off:  val_26 | 8);
            this.k3 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  val_13, off:  val_26 | 12);
            return;
            label_5:
            val_29 = "Poly1305 requires a 128 bit IV.";
            goto label_18;
            label_2:
            val_29 = "Poly1305 key must be 256 bits.";
            label_18:
            null = new System.ArgumentException(message:  val_29);
        }
        public string get_AlgorithmName()
        {
            if(this.cipher == null)
            {
                    return "Poly1305";
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            return "Poly1305-"("Poly1305-") + this.cipher.AlgorithmName;
        }
        public int GetMacSize()
        {
            return 16;
        }
        public void Update(byte input)
        {
            this.singleByte[0] = input;
            this.BlockUpdate(input:  this.singleByte, inOff:  0, len:  1);
        }
        public void BlockUpdate(byte[] input, int inOff, int len)
        {
            int val_4;
            int val_5;
            if(len < 1)
            {
                    return;
            }
            
            val_5 = this.currentBlockOffset;
            var val_5 = 0;
            do
            {
                if(val_5 == 16)
            {
                    this.ProcessBlock();
                val_5 = 0;
                this.currentBlockOffset = 0;
            }
            
                int val_3 = System.Math.Min(val1:  len - val_5, val2:  16 - val_5);
                System.Array.Copy(sourceArray:  input, sourceIndex:  val_5 + inOff, destinationArray:  this.currentBlock, destinationIndex:  this.currentBlockOffset, length:  val_3);
                val_5 = val_3 + val_5;
                val_4 = this.currentBlockOffset + val_3;
                this.currentBlockOffset = val_4;
            }
            while(val_5 < len);
        
        }
        private void ProcessBlock()
        {
            int val_19;
            uint val_20;
            if(this.currentBlockOffset <= 15)
            {
                    this.currentBlock[this.currentBlockOffset] = 1;
                int val_1 = this.currentBlockOffset + 1;
                if(val_1 <= 15)
            {
                    var val_2 = (long)val_1 + 32;
                do
            {
                val_1 = val_1 + 1;
                mem2[0] = 0;
                val_2 = val_2 + 1;
            }
            while(val_1 != 16);
            
            }
            
            }
            
            uint val_3 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  this.currentBlock, off:  0);
            val_19 = this.currentBlockOffset;
            uint val_18 = this.h0;
            val_18 = val_18 + (val_3 & 67108863);
            uint val_8 = this.h1 + ((ulong)(val_3 >> 26) & 67108863);
            uint val_9 = this.h2 + ((ulong)((Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  this.currentBlock, off:  4)) >> 20) & 67108863);
            uint val_19 = (ulong)((Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  this.currentBlock, off:  8)) >> 14) & 67108863;
            this.h0 = val_18;
            this.h1 = val_8;
            val_19 = this.h3 + val_19;
            val_20 = this.h4 + ((Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  this.currentBlock, off:  12)) >> 8);
            this.h2 = val_9;
            this.h3 = val_19;
            this.h4 = val_20;
            if(val_19 == 16)
            {
                    val_19 = 16777216;
                val_20 = val_20 + val_19;
                this.h4 = val_20;
            }
            
            uint val_20 = this.r0;
            uint val_22 = this.s3;
            uint val_21 = this.s4;
            var val_28 = val_18;
            uint val_27 = val_8;
            uint val_25 = this.s2;
            var val_23 = val_9;
            var val_24 = val_19;
            var val_26 = val_20;
            uint val_10 = val_20 * val_28;
            uint val_11 = val_27 * val_20;
            uint val_12 = val_23 * val_20;
            val_20 = val_26 * val_20;
            val_10 = val_10 + (val_21 * val_27);
            val_11 = val_11 + (val_23 * val_21);
            val_12 = val_12 + (val_24 * val_21);
            val_21 = (val_24 * val_20) + (val_26 * val_21);
            val_20 = val_20 + (this.r1 * val_24);
            val_10 = val_10 + (val_22 * val_23);
            val_11 = val_11 + (val_24 * val_22);
            val_22 = val_12 + (val_26 * val_22);
            val_21 = val_21 + (this.r1 * val_23);
            val_23 = val_20 + (this.r2 * val_23);
            val_24 = val_10 + (val_25 * val_24);
            val_25 = val_11 + (val_26 * val_25);
            val_22 = val_22 + (this.r1 * val_27);
            val_21 = val_21 + (this.r2 * val_27);
            val_23 = val_23 + (this.r3 * val_27);
            val_26 = val_24 + (this.s1 * val_26);
            uint val_14 = val_25 + (this.r1 * val_28);
            val_27 = val_22 + (this.r2 * val_28);
            val_21 = val_21 + (this.r3 * val_28);
            val_28 = val_23 + (this.r4 * val_28);
            val_26 = val_14 + (val_26 >> 26);
            val_14 = val_26 & 67108863;
            val_26 = val_27 + (val_26 >> 26);
            val_27 = val_26 & 67108863;
            val_26 = val_21 + (val_26 >> 26);
            uint val_16 = val_28;
            val_21 = val_26 & 67108863;
            val_16 = val_16 >> 26;
            val_16 = val_16 + (val_16 << 2);
            val_16 = (val_26 & 67108863) + val_16;
            this.h2 = val_27;
            this.h3 = val_21;
            this.h0 = val_16;
            this.h1 = val_14;
            this.h4 = val_16 & 67108863;
        }
        public int DoFinal(byte[] output, int outOff)
        {
            Org.BouncyCastle.Crypto.Check.DataLength(buf:  output, off:  outOff, len:  16, msg:  "Output buffer is too short.");
            if(this.currentBlockOffset >= 1)
            {
                    this.ProcessBlock();
            }
            
            uint val_21 = this.h0;
            uint val_22 = this.h1;
            uint val_23 = this.h2;
            uint val_24 = this.h3;
            uint val_25 = this.h4;
            uint val_1 = val_21 & 67108863;
            val_21 = val_22 + (val_21 >> 26);
            val_22 = val_21 & 67108863;
            val_21 = val_23 + (val_21 >> 26);
            val_23 = val_21 & 67108863;
            val_21 = val_24 + (val_21 >> 26);
            val_24 = val_21 & 67108863;
            val_21 = val_25 + (val_21 >> 26);
            val_25 = val_21 >> 26;
            val_25 = val_25 << 2;
            val_25 = val_25 + (val_21 >> 26);
            val_25 = val_25 + val_1;
            val_1 = val_25 + 5;
            uint val_2 = val_22 + (val_1 >> 26);
            uint val_3 = val_23 + (val_2 >> 26);
            uint val_4 = val_21 | 4227858432;
            uint val_5 = val_24 + (val_3 >> 26);
            val_4 = val_4 + (val_5 >> 26);
            uint val_6 = val_4 >> 31;
            val_21 = val_21 & (val_4 >> 31);
            val_6 = val_6 - 1;
            val_25 = val_25 & (val_4 >> 31);
            val_22 = val_22 & (val_4 >> 31);
            val_23 = val_23 & (val_4 >> 31);
            val_24 = val_24 & (val_4 >> 31);
            val_21 = val_21 & 67108863;
            val_4 = val_6 & val_4;
            val_1 = val_1 & val_6;
            val_2 = val_2 & val_6;
            val_3 = val_3 & val_6;
            val_5 = val_5 & val_6;
            val_1 = val_1 & 67108863;
            val_2 = val_2 & 67108863;
            val_25 = val_1 | val_25;
            val_22 = val_2 | val_22;
            val_23 = (val_3 & 67108863) | val_23;
            uint val_10 = (val_5 & 67108863) | val_24;
            this.h3 = val_10;
            this.h4 = val_4 | val_21;
            this.h0 = val_25;
            this.h1 = val_22;
            this.h2 = val_23;
            val_22 = val_22 >> 6;
            uint val_13 = (val_25 | (val_22 << 26)) + this.k0;
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  val_13, bs:  output, off:  outOff);
            val_13 = (val_22 + this.k1) + (val_13 >> 32);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  val_13, bs:  output, off:  outOff + 4);
            val_13 = ((val_23 >> 12) + this.k2) + (val_13 >> 32);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  val_13, bs:  output, off:  outOff + 8);
            uint val_18 = val_10 >> 18;
            val_22 = val_13 >> 32;
            val_18 = this.k3 + val_18;
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  val_18 + val_22, bs:  output, off:  outOff + 12);
            this.h1 = 0;
            this.h2 = 0;
            this.h3 = 0;
            this.h4 = 0;
            this.currentBlockOffset = 0;
            this.h0 = 0;
            return 16;
        }
        public void Reset()
        {
            this.h1 = 0;
            this.h2 = 0;
            this.h3 = 0;
            this.h4 = 0;
            this.currentBlockOffset = 0;
            this.h0 = 0;
        }
        private static ulong mul32x32_64(uint i1, uint i2)
        {
            return (ulong)i1;
        }
    
    }

}
