using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class TlsStreamCipher : TlsCipher
    {
        // Fields
        protected readonly Org.BouncyCastle.Crypto.Tls.TlsContext context;
        protected readonly Org.BouncyCastle.Crypto.IStreamCipher encryptCipher;
        protected readonly Org.BouncyCastle.Crypto.IStreamCipher decryptCipher;
        protected readonly Org.BouncyCastle.Crypto.Tls.TlsMac writeMac;
        protected readonly Org.BouncyCastle.Crypto.Tls.TlsMac readMac;
        protected readonly bool usesNonce;
        
        // Methods
        public TlsStreamCipher(Org.BouncyCastle.Crypto.Tls.TlsContext context, Org.BouncyCastle.Crypto.IStreamCipher clientWriteCipher, Org.BouncyCastle.Crypto.IStreamCipher serverWriteCipher, Org.BouncyCastle.Crypto.IDigest clientWriteDigest, Org.BouncyCastle.Crypto.IDigest serverWriteDigest, int cipherKeySize, bool usesNonce)
        {
            var val_33;
            int val_38;
            Org.BouncyCastle.Crypto.IStreamCipher val_39;
            Org.BouncyCastle.Crypto.ICipherParameters val_40;
            Org.BouncyCastle.Crypto.ICipherParameters val_41;
            var val_36 = 0;
            val_36 = val_36 + 1;
            this.context = context;
            this.encryptCipher = clientWriteCipher;
            this.usesNonce = usesNonce;
            this.decryptCipher = serverWriteCipher;
            var val_37 = 0;
            val_37 = val_37 + 1;
            int val_39 = clientWriteDigest.GetDigestSize();
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_33 = val_39 + (cipherKeySize << 1);
            val_39 = val_33 + serverWriteDigest.GetDigestSize();
            System.Byte[] val_8 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateKeyBlock(context:  context, size:  val_39);
            val_33 = 0;
            val_33 = val_33 + 1;
            Org.BouncyCastle.Crypto.Tls.TlsMac val_11 = new Org.BouncyCastle.Crypto.Tls.TlsMac(context:  context, digest:  clientWriteDigest, key:  val_8, keyOff:  0, keyLen:  clientWriteDigest.GetDigestSize());
            val_33 = 0;
            val_33 = val_33 + 1;
            int val_13 = clientWriteDigest.GetDigestSize();
            val_33 = 0;
            val_33 = val_33 + 1;
            Org.BouncyCastle.Crypto.Tls.TlsMac val_16 = new Org.BouncyCastle.Crypto.Tls.TlsMac(context:  context, digest:  serverWriteDigest, key:  val_8, keyOff:  val_13, keyLen:  serverWriteDigest.GetDigestSize());
            val_33 = 0;
            val_33 = val_33 + 1;
            int val_19 = serverWriteDigest.GetDigestSize() + val_13;
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_20 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_8, keyOff:  val_19, keyLen:  cipherKeySize);
            val_19 = val_19 + cipherKeySize;
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_21 = null;
            val_38 = cipherKeySize;
            val_21 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_8, keyOff:  val_19, keyLen:  val_38);
            int val_22 = val_19 + cipherKeySize;
            var val_23 = (val_22 == val_39) ? 1 : 0;
            if(val_22 == val_39)
            {
                    val_23 = context.IsServer & val_23;
                this.writeMac = (val_23 == true) ? (val_16) : (val_11);
                this.readMac = (val_23 == true) ? (val_11) : (val_16);
                this.encryptCipher = (val_23 == true) ? serverWriteCipher : clientWriteCipher;
                this.decryptCipher = (val_23 == true) ? clientWriteCipher : serverWriteCipher;
                if(usesNonce != false)
            {
                    byte[] val_30 = new byte[8];
                Org.BouncyCastle.Crypto.Parameters.ParametersWithIV val_31 = new Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(parameters:  (val_23 == true) ? (val_21) : (val_20), iv:  val_30);
                Org.BouncyCastle.Crypto.Parameters.ParametersWithIV val_32 = null;
                val_38 = 0;
                val_32 = new Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(parameters:  (val_23 == true) ? (val_20) : (val_21), iv:  val_30);
                val_39 = this.encryptCipher;
                val_40 = val_32;
                val_41 = val_31;
            }
            
                var val_40 = 0;
                val_40 = val_40 + 1;
                val_39.Init(forEncryption:  true, parameters:  val_31);
                var val_41 = 0;
                val_41 = val_41 + 1;
                this.decryptCipher.Init(forEncryption:  false, parameters:  val_32);
                return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_35 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public virtual int GetPlaintextLimit(int ciphertextLimit)
        {
            Org.BouncyCastle.Crypto.Tls.TlsMac val_1 = this.writeMac;
            val_1 = ciphertextLimit - val_1;
            return (int)val_1;
        }
        public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
        {
            Org.BouncyCastle.Crypto.Tls.TlsMac val_1 = this.writeMac + len;
            byte[] val_2 = new byte[0];
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.encryptCipher.ProcessBytes(input:  plaintext, inOff:  offset, length:  len, output:  val_2, outOff:  0);
            if(this.writeMac == null)
            {
                goto label_9;
            }
            
            if(this.encryptCipher != null)
            {
                goto label_15;
            }
            
            label_16:
            label_15:
            var val_6 = 0;
            val_6 = val_6 + 1;
            goto label_14;
            label_9:
            if(this.encryptCipher != null)
            {
                goto label_15;
            }
            
            goto label_16;
            label_14:
            this.encryptCipher.ProcessBytes(input:  this.writeMac, inOff:  0, length:  this.writeMac.secret, output:  val_2, outOff:  len);
            return (System.Byte[])val_2;
        }
        public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
        {
            Org.BouncyCastle.Crypto.Tls.TlsMac val_4 = this.readMac;
            if(val_4 <= len)
            {
                    byte[] val_1 = new byte[0];
                val_4 = len - val_4;
                var val_5 = 0;
                val_5 = val_5 + 1;
                this.decryptCipher.ProcessBytes(input:  ciphertext, inOff:  offset, length:  len, output:  val_1, outOff:  0);
                return Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  val_1, from:  0, to:  val_4);
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_3 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  50);
        }
        protected virtual void CheckMac(long seqNo, byte type, byte[] recBuf, int recStart, int recEnd, byte[] calcBuf, int calcOff, int calcLen)
        {
            if((Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a:  Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  recBuf, from:  recStart, to:  recEnd), b:  this.readMac)) != false)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_3 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  20);
        }
        protected virtual void UpdateIV(Org.BouncyCastle.Crypto.IStreamCipher cipher, bool forEncryption, long seqNo)
        {
            byte[] val_1 = new byte[8];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(i:  seqNo, buf:  val_1, offset:  0);
            var val_5 = 0;
            val_5 = val_5 + 1;
            cipher.Init(forEncryption:  forEncryption, parameters:  new Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(parameters:  0, iv:  val_1));
        }
    
    }

}
