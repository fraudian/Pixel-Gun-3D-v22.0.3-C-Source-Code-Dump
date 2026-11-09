using UnityEngine;

namespace Org.BouncyCastle.Crypto.Encodings
{
    public class Pkcs1Encoding : IAsymmetricBlockCipher
    {
        // Fields
        public const string StrictLengthEnabledProperty = "Org.BouncyCastle.Pkcs1.Strict";
        private const int HeaderLength = 10;
        private static readonly bool[] strictLengthEnabled;
        private Org.BouncyCastle.Security.SecureRandom random;
        private Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine;
        private bool forEncryption;
        private bool forPrivateKey;
        private bool useStrictLength;
        private int pLen;
        private byte[] fallback;
        
        // Properties
        public static bool StrictLengthEnabled { get; set; }
        public string AlgorithmName { get; }
        
        // Methods
        public static bool get_StrictLengthEnabled()
        {
            null = null;
            if(Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.strictLengthEnabled.Length != 0)
            {
                    return (bool)Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.strictLengthEnabled + 32;
            }
            
            return (bool)Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.strictLengthEnabled + 32;
        }
        public static void set_StrictLengthEnabled(bool value)
        {
            null = null;
            Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.strictLengthEnabled.__unknownFiledOffset_20 = value;
        }
        private static Pkcs1Encoding()
        {
            bool val_5;
            string val_1 = Org.BouncyCastle.Utilities.Platform.GetEnvironmentVariable(variable:  "Org.BouncyCastle.Pkcs1.Strict");
            val_5 = 1;
            bool[] val_2 = new bool[1];
            if(val_1 != null)
            {
                    val_5 = val_1.Equals(value:  "true");
            }
            
            val_2[0] = val_5;
            Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.strictLengthEnabled = val_2;
        }
        public Pkcs1Encoding(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher)
        {
            var val_3;
            this.pLen = 0;
            this.engine = cipher;
            val_3 = null;
            this.useStrictLength = Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.StrictLengthEnabled;
        }
        public Pkcs1Encoding(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, int pLen)
        {
            var val_3;
            this.pLen = 0;
            this.engine = cipher;
            val_3 = null;
            this.useStrictLength = Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.StrictLengthEnabled;
            this.pLen = pLen;
        }
        public Pkcs1Encoding(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, byte[] fallback)
        {
            var val_3;
            this.pLen = 0;
            this.engine = cipher;
            val_3 = null;
            this.useStrictLength = Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.StrictLengthEnabled;
            this.fallback = fallback;
            this.pLen = fallback.Length;
        }
        public Org.BouncyCastle.Crypto.IAsymmetricBlockCipher GetUnderlyingCipher()
        {
            return (Org.BouncyCastle.Crypto.IAsymmetricBlockCipher)this.engine;
        }
        public string get_AlgorithmName()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.engine.AlgorithmName + "/PKCS1Padding"("/PKCS1Padding");
        }
        public void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            var val_10;
            this.random = new Org.BouncyCastle.Security.SecureRandom();
            val_10 = parameters;
            if(val_10 != null)
            {
                    val_10 = 0;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            bool val_5 = forEncryption;
            this.engine.Init(forEncryption:  val_5, parameters:  parameters);
            this.forPrivateKey = val_10.IsPrivate;
            this.forEncryption = val_5;
        }
        public int GetInputBlockSize()
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            int val_2 = this.engine.GetInputBlockSize();
            val_2 = (this.forEncryption == true) ? (val_2 - 10) : (val_2);
            return (int)val_2;
        }
        public int GetOutputBlockSize()
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            int val_2 = this.engine.GetOutputBlockSize();
            val_2 = (this.forEncryption == false) ? (val_2 - 10) : (val_2);
            return (int)val_2;
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
            int val_12;
            var val_13;
            int val_14;
            int val_15;
            if(this.GetInputBlockSize() < inLen)
            {
                goto label_1;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            int val_3 = this.engine.GetInputBlockSize();
            byte[] val_4 = new byte[0];
            if(this.forPrivateKey == false)
            {
                goto label_7;
            }
            
            val_12 = val_4.Length;
            if(val_12 == 0)
            {
                    val_12 = val_4.Length;
            }
            
            val_4[0] = 1;
            if(((~inLen) + val_12) == 1)
            {
                goto label_17;
            }
            
            do
            {
                val_13 = 1;
                val_4[val_13] = 255;
                val_12 = val_4.Length;
            }
            while((val_13 + 1) != ((~inLen) + val_12));
            
            goto label_17;
            label_7:
            val_14 = val_4.Length;
            val_4[0] = 2;
            if(((~inLen) + val_14) == 1)
            {
                goto label_17;
            }
            
            label_23:
            goto label_18;
            label_22:
            mem2[0] = this.random;
            val_15 = val_4.Length;
            label_18:
            if(null == null)
            {
                goto label_22;
            }
            
            val_12 = val_4.Length;
            val_13 = 1 + 1;
            if(val_13 != ((~inLen) + val_12))
            {
                goto label_23;
            }
            
            label_17:
            int val_10 = val_12 - inLen;
            val_10 = val_10 - 1;
            val_4[(long)val_10] = 0;
            inLen = val_4.Length - inLen;
            System.Array.Copy(sourceArray:  input, sourceIndex:  inOff, destinationArray:  val_4, destinationIndex:  inLen, length:  inLen);
            var val_14 = 0;
            val_14 = val_14 + 1;
            return this.engine.ProcessBlock(inBuf:  val_4, inOff:  0, inLen:  val_4.Length);
            label_1:
            System.ArgumentException val_12 = new System.ArgumentException(message:  "input data too large", paramName:  "inLen");
        }
        private static int CheckPkcs1Encoding(byte[] encoded, int pLen)
        {
            int val_6;
            var val_7;
            var val_8;
            if(encoded.Length != 0)
            {
                    val_6 = encoded.Length & 4294967295;
            }
            else
            {
                    val_6 = encoded.Length;
            }
            
            byte val_5 = encoded[0];
            int val_1 = pLen + 1;
            int val_2 = val_6 - val_1;
            val_5 = val_5 ^ 2;
            val_7 = val_5 & 255;
            if(val_2 < 2)
            {
                goto label_3;
            }
            
            val_8 = 0;
            goto label_4;
            label_6:
            val_6 = encoded.Length;
            val_8 = 1;
            label_4:
            val_6 = val_6 | (val_6 >> 1);
            val_6 = val_6 | (val_6 >> 2);
            val_6 = val_6 | (val_6 >> 4);
            val_6 = val_6 & 1;
            val_6 = val_6 - 1;
            val_7 = val_6 | val_7;
            if((val_2 - 2) != val_8)
            {
                goto label_6;
            }
            
            label_3:
            byte val_6 = encoded[(long)encoded.Length - val_1];
            val_6 = val_7 | val_6;
            val_6 = val_6 | (val_6 >> 1);
            val_6 = val_6 | (val_6 >> 2);
            val_6 = val_6 | (val_6 >> 4);
            val_6 = val_6 & 1;
            return (int)-val_6;
        }
        private byte[] DecodeBlockOrRandom(byte[] input, int inOff, int inLen)
        {
            string val_17;
            if(this.forPrivateKey == false)
            {
                goto label_1;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            System.Byte[] val_2 = this.engine.ProcessBlock(inBuf:  input, inOff:  inOff, inLen:  inLen);
            if(this.fallback == null)
            {
                goto label_7;
            }
            
            label_18:
            if(this.GetOutputBlockSize() > val_2.Length)
            {
                goto label_9;
            }
            
            if(this.useStrictLength == false)
            {
                goto label_10;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_15;
            label_7:
            byte[] val_4 = new byte[0];
            if(val_2 != null)
            {
                goto label_18;
            }
            
            goto label_18;
            label_15:
            if(this.engine.GetOutputBlockSize() != val_2.Length)
            {
                goto label_19;
            }
            
            label_10:
            int val_7 = Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.CheckPkcs1Encoding(encoded:  val_2, pLen:  this.pLen);
            byte[] val_8 = new byte[0];
            int val_14 = this.pLen;
            if(val_14 < 1)
            {
                    return (System.Byte[])val_8;
            }
            
            var val_18 = 0;
            do
            {
                int val_17 = val_2.Length;
                val_14 = val_17 - val_14;
                val_14 = val_18 + val_14;
                byte val_15 = val_2[(long)val_14];
                val_17 = val_7 ^ 255 & val_15;
                val_15 = (val_7 & this.fallback[0]) | val_17;
                val_8[0] = val_15;
                val_18 = val_18 + 1;
            }
            while(val_18 < this.pLen);
            
            return (System.Byte[])val_8;
            label_1:
            val_17 = "sorry, this method is only for decryption, not for signing";
            goto label_30;
            label_9:
            val_17 = "block truncated";
            goto label_30;
            label_19:
            val_17 = "block incorrect size";
            label_30:
            null = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  val_17);
        }
        private byte[] DecodeBlock(byte[] input, int inOff, int inLen)
        {
            int val_11;
            int val_12;
            int val_13;
            if(this.pLen != 1)
            {
                    return this.DecodeBlockOrRandom(input:  input, inOff:  inOff, inLen:  inLen);
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            System.Byte[] val_2 = this.engine.ProcessBlock(inBuf:  input, inOff:  inOff, inLen:  inLen);
            if(this.GetOutputBlockSize() > val_2.Length)
            {
                goto label_32;
            }
            
            byte val_11 = val_2[0];
            if((val_11 - 1) >= 2)
            {
                goto label_32;
            }
            
            if(this.useStrictLength == false)
            {
                goto label_11;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            goto label_16;
            label_11:
            val_11 = val_2.Length;
            goto label_17;
            label_16:
            val_11 = val_2.Length;
            if(this.engine.GetOutputBlockSize() != val_11)
            {
                goto label_32;
            }
            
            label_17:
            if(val_11 == 1)
            {
                goto label_32;
            }
            
            val_12 = 1;
            label_24:
            byte val_13 = val_2[1];
            if(val_13 == 0)
            {
                goto label_21;
            }
            
            if(val_11 == 1)
            {
                    if(val_13 != 255)
            {
                goto label_23;
            }
            
            }
            
            val_13 = val_2.Length;
            val_12 = val_12 + 1;
            if(val_12 != val_13)
            {
                goto label_24;
            }
            
            goto label_25;
            label_21:
            val_13 = val_2.Length;
            label_25:
            val_12 = val_12 + 1;
            if((val_12 < 10) || (val_12 > val_13))
            {
                goto label_32;
            }
            
            int val_7 = val_13 - val_12;
            byte[] val_8 = new byte[0];
            System.Array.Copy(sourceArray:  val_2, sourceIndex:  val_12, destinationArray:  val_8, destinationIndex:  0, length:  val_8.Length);
            return (System.Byte[])val_8;
            label_23:
            label_32:
            null = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  "block padding incorrect");
            goto label_32;
        }
    
    }

}
