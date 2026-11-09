using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class TlsAeadCipher : TlsCipher
    {
        // Fields
        public const int NONCE_RFC5288 = 1;
        internal const int NONCE_DRAFT_CHACHA20_POLY1305 = 2;
        protected readonly Org.BouncyCastle.Crypto.Tls.TlsContext context;
        protected readonly int macSize;
        protected readonly int record_iv_length;
        protected readonly Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher encryptCipher;
        protected readonly Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher decryptCipher;
        protected readonly byte[] encryptImplicitNonce;
        protected readonly byte[] decryptImplicitNonce;
        protected readonly int nonceMode;
        
        // Methods
        public TlsAeadCipher(Org.BouncyCastle.Crypto.Tls.TlsContext context, Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher clientWriteCipher, Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher serverWriteCipher, int cipherKeySize, int macSize)
        {
        
        }
        internal TlsAeadCipher(Org.BouncyCastle.Crypto.Tls.TlsContext context, Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher clientWriteCipher, Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher serverWriteCipher, int cipherKeySize, int macSize, int nonceMode)
        {
            var val_27;
            int val_28;
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context:  context)) == false)
            {
                goto label_9;
            }
            
            this.nonceMode = nonceMode;
            if(nonceMode == 2)
            {
                goto label_4;
            }
            
            if(nonceMode != 1)
            {
                goto label_9;
            }
            
            val_27 = 4;
            val_28 = 8;
            goto label_6;
            label_4:
            val_28 = 0;
            val_27 = 12;
            label_6:
            this.macSize = macSize;
            this.record_iv_length = val_28;
            this.context = context;
            int val_3 = (val_27 + cipherKeySize) << 1;
            System.Byte[] val_4 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateKeyBlock(context:  context, size:  val_3);
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_5 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_4, keyOff:  0, keyLen:  cipherKeySize);
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_6 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_4, keyOff:  cipherKeySize, keyLen:  cipherKeySize);
            int val_7 = val_27 + (cipherKeySize << 1);
            System.Byte[] val_9 = Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  val_4, from:  cipherKeySize << 1, to:  val_7);
            int val_10 = val_7 + val_27;
            System.Byte[] val_11 = Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  val_4, from:  val_7, to:  val_10);
            if(val_10 == val_3)
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                bool val_13 = context.IsServer;
                this.encryptCipher = (val_13 != true) ? serverWriteCipher : clientWriteCipher;
                this.decryptCipher = (val_13 != true) ? clientWriteCipher : serverWriteCipher;
                this.encryptImplicitNonce = (val_13 != true) ? (val_11) : (val_9);
                this.decryptImplicitNonce = (val_13 != true) ? (val_9) : (val_11);
                int val_18 = this.record_iv_length + val_27;
                byte[] val_21 = new byte[0];
                Org.BouncyCastle.Crypto.Parameters.AeadParameters val_23 = null;
                int val_22 = macSize << 3;
                val_23 = new Org.BouncyCastle.Crypto.Parameters.AeadParameters(key:  (val_13 != true) ? (val_6) : (val_5), macSize:  val_22, nonce:  val_21);
                var val_29 = 0;
                val_29 = val_29 + 1;
                this.encryptCipher.Init(forEncryption:  true, parameters:  val_23);
                var val_30 = 0;
                val_30 = val_30 + 1;
                this.decryptCipher.Init(forEncryption:  false, parameters:  new Org.BouncyCastle.Crypto.Parameters.AeadParameters(key:  (val_13 != true) ? (val_5) : (val_6), macSize:  val_22, nonce:  val_21));
                return;
            }
            
            label_9:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_27 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public virtual int GetPlaintextLimit(int ciphertextLimit)
        {
            int val_2 = this.macSize;
            val_2 = ciphertextLimit - val_2;
            return (int)val_2 - this.record_iv_length;
        }
        public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
        {
            int val_15;
            int val_16;
            var val_17;
            int val_19;
            int val_20;
            var val_24;
            var val_25;
            var val_26;
            val_15 = len;
            int val_1 = this.record_iv_length + this.encryptImplicitNonce.Length;
            byte[] val_2 = new byte[0];
            if(this.nonceMode == 2)
            {
                goto label_2;
            }
            
            if(this.nonceMode != 1)
            {
                goto label_42;
            }
            
            System.Array.Copy(sourceArray:  this.encryptImplicitNonce, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  this.encryptImplicitNonce.Length);
            val_16 = this.encryptImplicitNonce.Length;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(i:  seqNo, buf:  val_2, offset:  val_16);
            goto label_8;
            label_2:
            val_16 = val_2.Length - 8;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(i:  seqNo, buf:  val_2, offset:  val_16);
            val_17 = 0;
            goto label_12;
            label_17:
            if(val_17 >= val_2.Length)
            {
                    val_16 = 0;
            }
            
            if(val_17 >= this.encryptImplicitNonce.Length)
            {
                    val_16 = 0;
            }
            
            byte val_17 = this.encryptImplicitNonce[0];
            val_17 = 1;
            val_17 = val_17 ^ val_2[0];
            mem2[0] = val_17;
            label_12:
            if(val_17 < this.encryptImplicitNonce.Length)
            {
                goto label_17;
            }
            
            label_8:
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_16 = 11;
            int val_19 = val_15;
            val_19 = this.record_iv_length + (this.encryptCipher.GetOutputSize(len:  val_19));
            byte[] val_5 = new byte[0];
            val_19 = this.record_iv_length;
            if(val_19 != 0)
            {
                    if(val_2 == null)
            {
                    val_19 = this.record_iv_length;
            }
            
                System.Array.Copy(sourceArray:  val_2, sourceIndex:  val_2.Length - val_19, destinationArray:  val_5, destinationIndex:  0, length:  val_19);
                val_20 = this.record_iv_length;
            }
            else
            {
                    val_20 = 0;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            this.encryptCipher.Init(forEncryption:  true, parameters:  new Org.BouncyCastle.Crypto.Parameters.AeadParameters(key:  0, macSize:  this.macSize << 3, nonce:  val_2, associatedText:  this));
            var val_21 = 0;
            val_21 = val_21 + 1;
            Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher val_23 = this.encryptCipher;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_15 = (this.encryptCipher.ProcessBytes(inBytes:  plaintext, inOff:  offset, len:  val_15, outBytes:  val_5, outOff:  0)) + val_20;
            val_23 = (val_23.DoFinal(outBytes:  val_5, outOff:  val_15)) + val_15;
            if(val_23 == val_5.Length)
            {
                    return (System.Byte[])val_5;
            }
            
            label_42:
            val_24 = 1152921547519956032;
            val_25 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
            mem[8] = null;
            val_26 = 8;
        }
        public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
        {
            System.Byte[] val_16;
            System.Array val_17;
            var val_18;
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            if((this & 2147483648) != 0)
            {
                goto label_1;
            }
            
            val_16 = this.decryptImplicitNonce;
            int val_1 = this.record_iv_length + this.decryptImplicitNonce.Length;
            byte[] val_2 = new byte[0];
            if(this.nonceMode == 2)
            {
                goto label_3;
            }
            
            if(this.nonceMode != 1)
            {
                goto label_38;
            }
            
            System.Array.Copy(sourceArray:  this.decryptImplicitNonce, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  this.decryptImplicitNonce.Length);
            val_17 = val_2;
            System.Array.Copy(sourceArray:  ciphertext, sourceIndex:  offset, destinationArray:  val_2, destinationIndex:  val_2.Length - this.record_iv_length, length:  this.record_iv_length);
            goto label_7;
            label_3:
            val_17 = val_2.Length - 8;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(i:  seqNo, buf:  val_2, offset:  val_17);
            val_18 = 0;
            goto label_11;
            label_16:
            if(val_18 >= val_2.Length)
            {
                    val_17 = 0;
            }
            
            if(val_18 >= this.decryptImplicitNonce.Length)
            {
                    val_17 = 0;
            }
            
            byte val_19 = this.decryptImplicitNonce[0];
            val_18 = 1;
            val_19 = val_19 ^ val_2[0];
            mem2[0] = val_19;
            label_11:
            if(val_18 < this.decryptImplicitNonce.Length)
            {
                goto label_16;
            }
            
            label_7:
            int val_4 = len - this.record_iv_length;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_17 = 11;
            int val_6 = this.decryptCipher.GetOutputSize(len:  val_4);
            byte[] val_7 = new byte[0];
            var val_21 = 0;
            val_21 = val_21 + 1;
            this.decryptCipher.Init(forEncryption:  false, parameters:  new Org.BouncyCastle.Crypto.Parameters.AeadParameters(key:  0, macSize:  this.macSize << 3, nonce:  val_2, associatedText:  this));
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_16 = this.decryptCipher.ProcessBytes(inBytes:  ciphertext, inOff:  this.record_iv_length + offset, len:  val_4, outBytes:  val_7, outOff:  0);
            Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher val_24 = this.decryptCipher;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_24 = (val_24.DoFinal(outBytes:  val_7, outOff:  val_16)) + val_16;
            if(val_24 == val_7.Length)
            {
                    return (System.Byte[])val_7;
            }
            
            label_38:
            val_23 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_24 = 80;
            goto label_39;
            label_1:
            val_23 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_24 = 50;
            label_39:
            val_23 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  50);
            val_25 = 1152921547520552512;
            val_26 = val_23;
            mem[8] = null;
            val_27 = 8;
        }
        protected virtual byte[] GetAdditionalData(long seqNo, byte type, int len)
        {
            byte[] val_1 = new byte[13];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(i:  seqNo, buf:  val_1, offset:  0);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  type, buf:  val_1, offset:  8);
            var val_4 = 0;
            val_4 = val_4 + 1;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(version:  this.context.ServerVersion, buf:  val_1, offset:  9);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  len, buf:  val_1, offset:  11);
            return (System.Byte[])val_1;
        }
    
    }

}
