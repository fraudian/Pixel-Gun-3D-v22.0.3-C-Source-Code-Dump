using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class IesEngine
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.IBasicAgreement agree;
        private readonly Org.BouncyCastle.Crypto.IDerivationFunction kdf;
        private readonly Org.BouncyCastle.Crypto.IMac mac;
        private readonly Org.BouncyCastle.Crypto.BufferedBlockCipher cipher;
        private readonly byte[] macBuf;
        private bool forEncryption;
        private Org.BouncyCastle.Crypto.ICipherParameters privParam;
        private Org.BouncyCastle.Crypto.ICipherParameters pubParam;
        private Org.BouncyCastle.Crypto.Parameters.IesParameters param;
        
        // Methods
        public IesEngine(Org.BouncyCastle.Crypto.IBasicAgreement agree, Org.BouncyCastle.Crypto.IDerivationFunction kdf, Org.BouncyCastle.Crypto.IMac mac)
        {
            this.agree = agree;
            this.kdf = kdf;
            this.mac = mac;
            var val_4 = 0;
            val_4 = val_4 + 1;
            int val_2 = mac.GetMacSize();
            this.macBuf = new byte[0];
        }
        public IesEngine(Org.BouncyCastle.Crypto.IBasicAgreement agree, Org.BouncyCastle.Crypto.IDerivationFunction kdf, Org.BouncyCastle.Crypto.IMac mac, Org.BouncyCastle.Crypto.BufferedBlockCipher cipher)
        {
            val_1 = new System.Object();
            this.agree = agree;
            this.kdf = kdf;
            this.mac = mac;
            var val_5 = 0;
            val_5 = val_5 + 1;
            int val_3 = mac.GetMacSize();
            this.cipher = val_1;
            this.macBuf = new byte[0];
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters privParameters, Org.BouncyCastle.Crypto.ICipherParameters pubParameters, Org.BouncyCastle.Crypto.ICipherParameters iesParameters)
        {
            Org.BouncyCastle.Crypto.ICipherParameters val_4 = iesParameters;
            this.forEncryption = forEncryption;
            this.privParam = privParameters;
            this.pubParam = pubParameters;
            if(val_4 != null)
            {
                    val_4 = 0;
            }
            
            this.param = val_4;
        }
        private byte[] DecryptBlock(byte[] in_enc, int inOff, int inLen, byte[] z)
        {
            System.Byte[] val_35;
            Org.BouncyCastle.Crypto.Parameters.IesParameters val_39;
            var val_40;
            int val_41;
            Org.BouncyCastle.Crypto.ICipherParameters val_42;
            System.Byte[] val_43;
            int val_44;
            string val_50;
            var val_51;
            int val_41 = inLen;
            int val_50 = inOff;
            Org.BouncyCastle.Crypto.Parameters.KdfParameters val_2 = null;
            val_35 = this.param.GetDerivationV();
            val_2 = new Org.BouncyCastle.Crypto.Parameters.KdfParameters(shared:  z, iv:  val_35);
            int val_45 = this.param.MacKeySize;
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_35 = 0;
            this.kdf.Init(parameters:  val_2);
            var val_39 = 0;
            val_39 = val_39 + 1;
            if(this.mac.GetMacSize() > val_41)
            {
                goto label_13;
            }
            
            var val_40 = 0;
            val_40 = val_40 + 1;
            val_41 = val_41 - this.mac.GetMacSize();
            if(this.cipher == null)
            {
                goto label_19;
            }
            
            val_39 = this.param;
            if(val_39 == null)
            {
                goto label_20;
            }
            
            val_39 = 0;
            goto label_25;
            label_19:
            var val_13 = (val_45 < 0) ? (val_45 + 7) : (val_45);
            System.Byte[] val_16 = this.GenerateKdfBytes(kParam:  val_2, length:  val_41 + (val_13 >> 3));
            val_40 = new byte[0];
            if(val_41 != 0)
            {
                    var val_44 = 0;
                do
            {
                byte val_42 = in_enc[(long)val_50 + val_44];
                val_42 = val_16[0] ^ val_42;
                val_44 = val_44 + 1;
                val_40[0] = val_42;
            }
            while(val_41 != val_44);
            
            }
            
            val_41 = val_13 >> 3;
            val_42 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter();
            val_43 = val_16;
            val_44 = val_41;
            goto label_34;
            label_20:
            label_25:
            int val_19 = val_39.CipherKeySize;
            val_39 = ((val_19 < 0) ? (val_19 + 7) : (val_19)) >> 3;
            var val_23 = (val_45 < 0) ? (val_45 + 7) : (val_45);
            val_45 = val_23 >> 3;
            System.Byte[] val_25 = this.GenerateKdfBytes(kParam:  val_2, length:  val_39 + (val_23 >> 3));
            1152921539322491168 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_25, keyOff:  0, keyLen:  val_39);
            val_40 = this.cipher;
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_27 = 1152921539322491168;
            val_42 = val_27;
            val_43 = val_25;
            val_44 = val_39;
            val_41 = val_45;
            label_34:
            val_27 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_43, keyOff:  val_44, keyLen:  val_41);
            System.Byte[] val_28 = this.param.GetEncodingV();
            var val_46 = 0;
            val_46 = val_46 + 1;
            val_44 = 0;
            this.mac.Init(parameters:  val_42);
            var val_47 = 0;
            val_47 = val_47 + 1;
            this.mac.BlockUpdate(input:  in_enc, inOff:  val_50, len:  val_41);
            if(val_28 == null)
            {
                goto label_48;
            }
            
            label_55:
            var val_48 = 0;
            val_48 = val_48 + 1;
            goto label_53;
            label_48:
            if(this.mac != null)
            {
                goto label_55;
            }
            
            goto label_55;
            label_53:
            this.mac.BlockUpdate(input:  val_28, inOff:  0, len:  val_28.Length);
            var val_49 = 0;
            val_49 = val_49 + 1;
            int val_33 = this.mac.DoFinal(output:  this.macBuf, outOff:  0);
            val_50 = val_41 + val_50;
            if((Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a:  Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  in_enc, from:  val_50, to:  val_50 + this.macBuf.Length), b:  this.macBuf)) == false)
            {
                goto label_62;
            }
            
            return (System.Byte[])val_40;
            label_13:
            val_50 = "Length of input must be greater than the MAC";
            goto label_63;
            label_62:
            Org.BouncyCastle.Crypto.InvalidCipherTextException val_37 = null;
            val_50 = "Invalid MAC.";
            label_63:
            val_37 = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  val_50);
            val_51 = val_37;
        }
        private byte[] EncryptBlock(byte[] input, int inOff, int inLen, byte[] z)
        {
            int val_34;
            Org.BouncyCastle.Crypto.Parameters.IesParameters val_35;
            var val_37;
            System.Array val_39;
            Org.BouncyCastle.Crypto.ICipherParameters val_40;
            System.Byte[] val_41;
            int val_42;
            int val_43;
            val_34 = inLen;
            Org.BouncyCastle.Crypto.Parameters.KdfParameters val_2 = new Org.BouncyCastle.Crypto.Parameters.KdfParameters(shared:  z, iv:  this.param.GetDerivationV());
            var val_37 = this.param.MacKeySize;
            if(this.cipher == null)
            {
                goto label_3;
            }
            
            val_35 = this.param;
            if(val_35 == null)
            {
                goto label_4;
            }
            
            val_35 = 0;
            goto label_9;
            label_3:
            val_37 = (val_37 < 0) ? (val_37 + 7) : (val_37);
            System.Byte[] val_9 = this.GenerateKdfBytes(kParam:  val_2, length:  val_34 + (val_37 >> 3));
            var val_38 = 0;
            val_38 = val_38 + 1;
            goto label_14;
            label_4:
            label_9:
            int val_11 = val_35.CipherKeySize;
            val_35 = ((val_11 < 0) ? (val_11 + 7) : (val_11)) >> 3;
            var val_15 = (val_37 < 0) ? (val_37 + 7) : (val_37);
            System.Byte[] val_17 = this.GenerateKdfBytes(kParam:  val_2, length:  val_35 + (val_15 >> 3));
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_18 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_17, keyOff:  0, keyLen:  val_35);
            val_34 = this.cipher + this.cipher;
            var val_39 = 0;
            val_39 = val_39 + 1;
            int val_23 = this.mac.GetMacSize() + val_34;
            byte[] val_24 = new byte[0];
            val_39 = val_24;
            System.Array.Copy(sourceArray:  new byte[0], sourceIndex:  0, destinationArray:  val_24, destinationIndex:  0, length:  val_34);
            val_40 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter();
            val_41 = val_17;
            val_42 = val_35;
            val_43 = val_15 >> 3;
            goto label_24;
            label_14:
            int val_27 = this.mac.GetMacSize() + val_34;
            byte[] val_28 = new byte[0];
            val_39 = val_28;
            if(val_34 != 0)
            {
                    var val_42 = 0;
                do
            {
                byte val_40 = input[(long)inOff + val_42];
                val_37 = 0;
                val_40 = val_9[val_37] ^ val_40;
                val_42 = val_42 + 1;
                val_39[val_37] = val_40;
            }
            while(val_34 != val_42);
            
            }
            
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_30 = null;
            val_43 = val_37 >> 3;
            val_40 = val_30;
            val_41 = val_9;
            val_42 = val_34;
            label_24:
            val_30 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_41, keyOff:  val_42, keyLen:  val_43);
            System.Byte[] val_31 = this.param.GetEncodingV();
            var val_43 = 0;
            val_43 = val_43 + 1;
            val_42 = 0;
            this.mac.Init(parameters:  val_30);
            var val_44 = 0;
            val_44 = val_44 + 1;
            this.mac.BlockUpdate(input:  val_28, inOff:  0, len:  val_34);
            if(val_31 == null)
            {
                goto label_44;
            }
            
            label_51:
            var val_45 = 0;
            val_45 = val_45 + 1;
            goto label_49;
            label_44:
            if(this.mac != null)
            {
                goto label_51;
            }
            
            goto label_51;
            label_49:
            this.mac.BlockUpdate(input:  val_31, inOff:  0, len:  val_31.Length);
            var val_46 = 0;
            val_46 = val_46 + 1;
            int val_36 = this.mac.DoFinal(output:  val_28, outOff:  val_34);
            return val_39;
        }
        private byte[] GenerateKdfBytes(Org.BouncyCastle.Crypto.Parameters.KdfParameters kParam, int length)
        {
            byte[] val_1 = new byte[0];
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.kdf.Init(parameters:  kParam);
            if(val_1 == null)
            {
                goto label_6;
            }
            
            if(this.kdf != null)
            {
                goto label_12;
            }
            
            label_13:
            label_12:
            var val_6 = 0;
            val_6 = val_6 + 1;
            goto label_11;
            label_6:
            if(this.kdf != null)
            {
                goto label_12;
            }
            
            goto label_13;
            label_11:
            int val_4 = this.kdf.GenerateBytes(output:  val_1, outOff:  0, length:  val_1.Length);
            return (System.Byte[])val_1;
        }
        public virtual byte[] ProcessBlock(byte[] input, int inOff, int inLen)
        {
            var val_8;
            var val_11;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_8 = public System.Void Org.BouncyCastle.Crypto.IBasicAgreement::Init(Org.BouncyCastle.Crypto.ICipherParameters parameters);
            this.agree.Init(parameters:  this.privParam);
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_8 = 2;
            var val_11 = 0;
            val_11 = val_11 + 1;
            System.Byte[] val_6 = Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(length:  this.agree.GetFieldSize(), n:  this.agree.CalculateAgreement(pubKey:  this.pubParam));
            if(this.forEncryption != false)
            {
                    val_11 = this.EncryptBlock(input:  input, inOff:  inOff, inLen:  inLen, z:  val_6);
            }
            else
            {
                    val_11 = this.DecryptBlock(in_enc:  input, inOff:  inOff, inLen:  inLen, z:  val_6);
            }
            
            System.Array.Clear(array:  val_6, index:  0, length:  val_6.Length);
            if(0 != 1)
            {
                    return (System.Byte[])val_11;
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])val_11;
            }
            
            return (System.Byte[])val_11;
        }
    
    }

}
