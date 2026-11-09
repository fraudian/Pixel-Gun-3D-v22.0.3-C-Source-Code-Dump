using UnityEngine;

namespace Org.BouncyCastle.Crypto.Encodings
{
    public class ISO9796d1Encoding : IAsymmetricBlockCipher
    {
        // Fields
        private static readonly Org.BouncyCastle.Math.BigInteger Sixteen;
        private static readonly Org.BouncyCastle.Math.BigInteger Six;
        private static readonly byte[] shadows;
        private static readonly byte[] inverse;
        private readonly Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine;
        private bool forEncryption;
        private int bitSize;
        private int padBits;
        private Org.BouncyCastle.Math.BigInteger modulus;
        
        // Properties
        public string AlgorithmName { get; }
        
        // Methods
        public ISO9796d1Encoding(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher)
        {
            this.engine = cipher;
        }
        public string get_AlgorithmName()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.engine.AlgorithmName + "/ISO9796-1Padding"("/ISO9796-1Padding");
        }
        public Org.BouncyCastle.Crypto.IAsymmetricBlockCipher GetUnderlyingCipher()
        {
            return (Org.BouncyCastle.Crypto.IAsymmetricBlockCipher)this.engine;
        }
        public void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            var val_11;
            if(parameters != null)
            {
                    val_11 = parameters;
            }
            
            val_11 = 0;
            var val_9 = 0;
            val_9 = val_9 + 1;
            this.engine.Init(forEncryption:  forEncryption, parameters:  parameters);
            Org.BouncyCastle.Math.BigInteger val_6 = val_11.Modulus;
            this.modulus = val_6;
            this.bitSize = val_6.BitLength;
            this.forEncryption = forEncryption;
        }
        public int GetInputBlockSize()
        {
            var val_6;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = this.engine;
            int val_2 = val_6.GetInputBlockSize();
            if(this.forEncryption == false)
            {
                    return (int)val_6;
            }
            
            val_6 = (((val_2 + 1) < 0) ? (val_2 + 2) : (val_2 + 1)) >> 1;
            return (int)val_6;
        }
        public int GetOutputBlockSize()
        {
            var val_6;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = this.engine;
            int val_2 = val_6.GetOutputBlockSize();
            if(this.forEncryption == true)
            {
                    return (int)val_6;
            }
            
            val_6 = (((val_2 + 1) < 0) ? (val_2 + 2) : (val_2 + 1)) >> 1;
            return (int)val_6;
        }
        public void SetPadBits(int padBits)
        {
            if(padBits < 8)
            {
                    this.padBits = padBits;
                return;
            }
            
            System.ArgumentException val_1 = new System.ArgumentException(message:  "padBits > 7");
        }
        public int GetPadBits()
        {
            return (int)this.padBits;
        }
        public byte[] ProcessBlock(byte[] input, int inOff, int length)
        {
            if(this.forEncryption == false)
            {
                    return this.DecodeBlock(input:  input, inOff:  inOff, inLen:  length);
            }
            
            return this.EncodeBlock(input:  input, inOff:  inOff, inLen:  length);
        }
        private byte[] EncodeBlock(byte[] input, int inOff, int inLen)
        {
            System.Array val_34;
            int val_35;
            var val_36;
            int val_37;
            var val_38;
            var val_39;
            int val_40;
            int val_41;
            byte val_42;
            var val_43;
            val_34 = input;
            int val_32 = this.bitSize;
            int val_1 = val_32 + 7;
            val_32 = val_32 + 14;
            var val_3 = ((val_1 < 0) ? (val_32) : (val_1)) >> 3;
            byte[] val_4 = new byte[0];
            int val_5 = this.bitSize + 13;
            var val_8 = ((val_5 < 0) ? (this.bitSize + 28) : (val_5)) >> 4;
            if(val_5 >= 16)
            {
                    do
            {
                if(0 > (val_8 - inLen))
            {
                    val_35 = val_8 - 0;
                System.Array.Copy(sourceArray:  val_34, sourceIndex:  (inLen + inOff) - val_35, destinationArray:  val_4, destinationIndex:  val_4.Length - val_8, length:  val_35);
                val_36 = 0 + inLen;
            }
            else
            {
                    val_36 = 0 + inLen;
                inLen = val_4.Length - val_36;
                val_35 = inLen;
                System.Array.Copy(sourceArray:  val_34, sourceIndex:  inOff, destinationArray:  val_4, destinationIndex:  inLen, length:  val_35);
            }
            
            }
            while(val_8 > val_36);
            
            }
            
            val_37 = val_4.Length;
            val_38 = val_37;
            if((this.bitSize + 28) >= 31)
            {
                    int val_14 = val_38 - (val_8 << 1);
                do
            {
                val_34 = val_14;
                val_38 = val_38 - val_8;
                val_14 = (val_34 < 0) ? (val_34 + 1) : (val_34);
                val_38 = val_38 + (val_14 >> 1);
                val_39 = null;
                byte val_33 = val_4[(long)val_38];
                val_39 = null;
                System.Byte[] val_16 = Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows + (val_33 >> 4);
                byte val_34 = (Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows + (val_4[(long)(int)(((val_4.Length - (val_5 < 0 ? (this.bitSize + 28) : (this.bitSize + 13) >> 4)) + ((int)val_34 < 0 ? ((val_4.Length - ( + 32;
                System.Byte[] val_18 = Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows + (val_33 & 15);
                val_36 = (long)val_34;
                val_34 = ((Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows + (val_4[(long)(int)(((val_4.Length - (val_5 < 0 ? (this.bitSize + 28) : (this.bitSize + 13) >> 4)) + ((int)val_34 < 0 ? ((val_4.Length - ( + 32) | (val_34 << 4);
                val_4[val_36] = val_34;
                val_4[(long)val_34 + 1] = val_33;
                val_37 = val_4.Length;
            }
            while((((long)val_34 + 1) + 1) != val_37);
            
                val_38 = val_34 + 2;
            }
            
            val_38 = val_38 - (inLen << 1);
            byte val_35 = val_4[(long)val_38];
            val_35 = (this.padBits + 1) ^ val_35;
            val_4[(long)val_38] = val_35;
            val_40 = val_4.Length;
            if(val_40 == 0)
            {
                    val_40 = val_4.Length;
            }
            
            byte val_36 = val_4[((-4294967296) + ((val_4.Length) << 32)) >> 32];
            val_4[((-4294967296) + ((val_4.Length) << 32)) >> 32] = 6;
            int val_37 = this.bitSize;
            int val_26 = val_37 - 1;
            val_37 = val_37 + 6;
            var val_27 = (val_26 < 0) ? (val_37) : (val_26);
            val_41 = val_4.Length;
            val_27 = val_27 & 4294967288;
            val_26 = val_26 - val_27;
            if(val_26 != 0)
            {
                    if(val_41 == 0)
            {
                    val_41 = val_4.Length;
            }
            
                int val_29 = (8 - val_26) & 31;
                var val_39 = 255;
                val_39 = val_39 >> val_29;
                val_42 = val_39 & val_4[0];
                val_4[0] = val_42;
                if(val_41 == 0)
            {
                    val_42 = val_4[0];
            }
            
                byte val_40 = 128;
                val_40 = val_40 >> val_29;
                val_40 = val_40 | val_42;
                val_43 = 0;
                val_4[0] = val_40;
            }
            else
            {
                    val_4[0] = 0;
                byte val_41 = val_4[0];
                val_43 = 1;
                val_41 = val_41 | 128;
                val_4[0] = val_41;
            }
            
            var val_42 = 0;
            val_42 = val_42 + 1;
            return this.engine.ProcessBlock(inBuf:  val_4, inOff:  1, inLen:  val_4.Length - val_43);
        }
        private byte[] DecodeBlock(byte[] input, int inOff, int inLen)
        {
            Org.BouncyCastle.Math.BigInteger val_35;
            var val_36;
            var val_37;
            var val_38;
            int val_39;
            var val_40;
            var val_41;
            var val_42;
            int val_43;
            byte val_44;
            int val_45;
            byte val_46;
            var val_47;
            var val_34 = 0;
            val_34 = val_34 + 1;
            int val_35 = this.bitSize;
            int val_3 = val_35 + 13;
            val_35 = val_35 + 28;
            var val_4 = (val_3 < 0) ? (val_35) : (val_3);
            Org.BouncyCastle.Math.BigInteger val_5 = null;
            val_35 = val_5;
            val_5 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  this.engine.ProcessBlock(inBuf:  input, inOff:  inOff, inLen:  inLen));
            val_36 = null;
            val_36 = null;
            if(((val_5.Mod(m:  Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.Sixteen)) & 1) == 0)
            {
                    val_37 = null;
                val_35 = this.modulus.Subtract(n:  val_5);
                val_37 = null;
                if(((val_35.Mod(m:  Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.Sixteen)) & 1) == 0)
            {
                goto label_57;
            }
            
            }
            
            System.Byte[] val_9 = val_35.ToByteArrayUnsigned();
            var val_36 = -4294967296;
            val_36 = val_36 + ((val_9.Length) << 32);
            byte val_37 = val_9[val_36 >> 32];
            val_37 = val_37 & 15;
            if(val_37 != 6)
            {
                goto label_57;
            }
            
            var val_38 = -4294967296;
            val_38 = val_38 + ((val_9.Length) << 32);
            val_38 = null;
            val_38 = null;
            var val_40 = -8589934592;
            val_40 = val_40 + ((val_9.Length) << 32);
            byte val_41 = val_9[val_40 >> 32];
            val_41 = val_41 >> 4;
            System.Byte[] val_13 = Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.inverse + val_41;
            var val_42 = -4294967296;
            val_42 = val_42 + ((val_9.Length) << 32);
            val_9[val_42 >> 32] = (val_9[val_38 >> 32]) >> 4;
            byte val_43 = val_9[0];
            val_43 = val_43 >> 4;
            System.Byte[] val_16 = Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows + val_43;
            byte val_45 = (Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows + (val_9[0] >> 4)) + 32;
            byte val_44 = val_9[0];
            byte val_17 = val_44 & 15;
            val_44 = val_44 & 15;
            System.Byte[] val_18 = Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows + val_44;
            val_39 = val_9.Length;
            var val_19 = val_4 >> 4;
            val_45 = ((Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows + (val_9[0] & 15)) + 32) | (val_45 << 4);
            if(val_39 == 0)
            {
                    val_39 = val_9.Length;
            }
            
            int val_20 = val_39 - 1;
            val_9[0] = val_45;
            if(val_20 >= (val_39 - (val_19 << 1)))
            {
                goto label_35;
            }
            
            val_40 = 0;
            val_41 = 1;
            goto label_36;
            label_35:
            val_40 = 0;
            val_4 = val_19 << 1;
            val_41 = 1;
            label_49:
            val_42 = null;
            val_42 = null;
            val_43 = val_9.Length;
            byte val_46 = val_9[(long)val_20];
            val_46 = val_46 >> 4;
            System.Byte[] val_22 = Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows + val_46;
            var val_48 = (Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows + (val_9[(long)(int)((val_9.Length - 1))][0] >> 4)) + 32;
            var val_47 = val_9[(long)(int)((val_9.Length - 1))] + 32;
            var val_23 = val_47 & 15;
            val_47 = val_47 & 15;
            System.Byte[] val_24 = Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows + val_47;
            int val_25 = val_20 - 1;
            val_48 = ((Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows + (val_9[(long)(int)((val_9.Length - 1))] + 32 & 15)) + 32) | (val_48 << 4);
            val_44 = val_9[(long)val_25];
            if(val_44 == val_48)
            {
                goto label_46;
            }
            
            if((0 & 1) != 0)
            {
                goto label_47;
            }
            
            if(val_25 >= val_9.Length)
            {
                    val_44 = mem[val_9[(long)(int)(((val_9.Length - 1) - 1))] + 32];
                val_44 = val_9[(long)(int)(((val_9.Length - 1) - 1))] + 32;
            }
            
            val_41 = (val_48 & 255) ^ val_44;
            val_40 = val_25;
            label_46:
            val_45 = val_9.Length;
            val_20 = val_20 - 2;
            if(val_20 >= (val_45 - val_4))
            {
                goto label_49;
            }
            
            label_36:
            val_46 = (long)val_40;
            val_9[val_46] = 0;
            int val_49 = val_9.Length;
            val_49 = val_49 - val_46;
            var val_29 = ((val_49 < 0) ? (val_49 + 1) : (val_49)) >> 1;
            byte[] val_30 = new byte[0];
            val_47 = 0;
            var val_31 = val_46 + 1;
            goto label_51;
            label_55:
            val_46 = val_9[(long)val_31];
            val_40 = 0;
            val_47 = 1;
            val_31 = val_31 + 2;
            val_30[val_40] = val_46;
            label_51:
            if(val_47 < val_30.Length)
            {
                goto label_55;
            }
            
            mem[1152921553226213936] = val_41 - 1;
            return (System.Byte[])val_30;
            label_47:
            label_57:
            null = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  "invalid tsums in block");
            goto label_57;
        }
        private static ISO9796d1Encoding()
        {
            Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.Sixteen = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  16);
            Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.Six = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  6);
            Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows = new byte[16] {14, 3, 5, 8, 9, 4, 2, 15, 0, 13, 11, 6, 7, 10, 12, 1};
            Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.inverse = new byte[16] {8, 15, 6, 1, 5, 2, 11, 12, 3, 4, 13, 10, 14, 9, 0, 7};
        }
    
    }

}
