using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class Chacha20Poly1305 : TlsCipher
    {
        // Fields
        private static readonly byte[] Zeroes;
        protected readonly Org.BouncyCastle.Crypto.Tls.TlsContext context;
        protected readonly Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine encryptCipher;
        protected readonly Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine decryptCipher;
        protected readonly byte[] encryptIV;
        protected readonly byte[] decryptIV;
        
        // Methods
        public Chacha20Poly1305(Org.BouncyCastle.Crypto.Tls.TlsContext context)
        {
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context:  context)) != false)
            {
                    this.context = context;
                System.Byte[] val_2 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateKeyBlock(context:  context, size:  88);
                Org.BouncyCastle.Crypto.Parameters.KeyParameter val_3 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_2, keyOff:  0, keyLen:  32);
                Org.BouncyCastle.Crypto.Parameters.KeyParameter val_4 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_2, keyOff:  32, keyLen:  32);
                System.Byte[] val_5 = Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  val_2, from:  64, to:  76);
                System.Byte[] val_6 = Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  val_2, from:  76, to:  88);
                this.encryptCipher = new Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine();
                this.decryptCipher = new Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine();
                var val_18 = 0;
                val_18 = val_18 + 1;
                bool val_10 = context.IsServer;
                System.Byte[] val_11 = (val_10 != true) ? (val_6) : (val_5);
                this.encryptIV = val_11;
                this.decryptIV = (val_10 != true) ? (val_5) : (val_6);
                Org.BouncyCastle.Crypto.Parameters.ParametersWithIV val_15 = new Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(parameters:  (val_10 != true) ? (val_4) : (val_3), iv:  val_11);
                Org.BouncyCastle.Crypto.Parameters.ParametersWithIV val_16 = new Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(parameters:  (val_10 != true) ? (val_3) : (val_4), iv:  this.decryptIV);
                if(this.decryptCipher != null)
            {
                goto typeof(Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine).__il2cppRuntimeField_1B8;
            }
            
            }
            else
            {
                    Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_17 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
            }
        
        }
        public virtual int GetPlaintextLimit(int ciphertextLimit)
        {
            return (int)ciphertextLimit - 16;
        }
        public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
        {
            int val_1 = len + 16;
            byte[] val_2 = new byte[0];
            System.Array.Copy(sourceArray:  this, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  len, length:  this.encryptCipher);
            return (System.Byte[])val_2;
        }
        public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
        {
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_8;
            var val_9;
            if((this & 2147483648) != 0)
            {
                goto label_1;
            }
            
            if((Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a:  this, b:  Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  ciphertext, from:  (len - 16) + offset, to:  len + offset))) == false)
            {
                goto label_2;
            }
            
            if(this.decryptCipher != null)
            {
                    return (System.Byte[])new byte[0];
            }
            
            return (System.Byte[])new byte[0];
            label_1:
            val_8 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_9 = 50;
            goto label_4;
            label_2:
            val_8 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_9 = 20;
            label_4:
            val_8 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  20);
        }
        protected virtual Org.BouncyCastle.Crypto.Parameters.KeyParameter InitRecord(Org.BouncyCastle.Crypto.IStreamCipher cipher, bool forEncryption, long seqNo, byte[] iv)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            cipher.Init(forEncryption:  forEncryption, parameters:  new Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(parameters:  0, iv:  this));
            goto typeof(Org.BouncyCastle.Crypto.Tls.Chacha20Poly1305).__il2cppRuntimeField_1E8;
        }
        protected virtual byte[] CalculateNonce(long seqNo, byte[] iv)
        {
            byte[] val_1 = new byte[12];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(i:  seqNo, buf:  val_1, offset:  4);
            var val_3 = 0;
            do
            {
                mem2[0] = 1152921505721910208 ^ 1152921505721910208;
                val_3 = val_3 + 1;
            }
            while(val_3 != 12);
            
            return (System.Byte[])val_1;
        }
        protected virtual Org.BouncyCastle.Crypto.Parameters.KeyParameter GenerateRecordMacKey(Org.BouncyCastle.Crypto.IStreamCipher cipher)
        {
            byte[] val_1 = new byte[64];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(cipher != null)
            {
                goto label_7;
            }
            
            label_8:
            label_7:
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_6;
            label_1:
            if(cipher != null)
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            cipher.ProcessBytes(input:  val_1, inOff:  0, length:  val_1.Length, output:  val_1, outOff:  0);
            Org.BouncyCastle.Utilities.Arrays.Fill(buf:  val_1, b:  0);
            return (Org.BouncyCastle.Crypto.Parameters.KeyParameter)new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_1, keyOff:  0, keyLen:  32);
        }
        protected virtual byte[] CalculateRecordMac(Org.BouncyCastle.Crypto.Parameters.KeyParameter macKey, byte[] additionalData, byte[] buf, int off, int len)
        {
            Org.BouncyCastle.Crypto.Macs.Poly1305 val_1 = new Org.BouncyCastle.Crypto.Macs.Poly1305();
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_1.Init(parameters:  macKey);
            return Org.BouncyCastle.Security.MacUtilities.DoFinal(mac:  val_1);
        }
        protected virtual void UpdateRecordMacLength(Org.BouncyCastle.Crypto.IMac mac, int len)
        {
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(n:  (long)len);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(mac != null)
            {
                goto label_7;
            }
            
            label_8:
            label_7:
            var val_3 = 0;
            val_3 = val_3 + 1;
            goto label_6;
            label_1:
            if(mac != null)
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            mac.BlockUpdate(input:  val_1, inOff:  0, len:  val_1.Length);
        }
        protected virtual void UpdateRecordMacText(Org.BouncyCastle.Crypto.IMac mac, byte[] buf, int off, int len)
        {
            var val_7;
            var val_6 = 0;
            val_6 = val_6 + 1;
            mac.BlockUpdate(input:  buf, inOff:  off, len:  len);
            var val_3 = (len < 0) ? (len + 15) : len;
            val_3 = val_3 & 4294967280;
            int val_4 = len - val_3;
            if(val_4 == 0)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            val_4 = 16 - val_4;
            var val_7 = 0;
            val_7 = val_7 + 1;
            mac.BlockUpdate(input:  Org.BouncyCastle.Crypto.Tls.Chacha20Poly1305.Zeroes, inOff:  0, len:  val_4);
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
        private static Chacha20Poly1305()
        {
            Org.BouncyCastle.Crypto.Tls.Chacha20Poly1305.Zeroes = new byte[15];
        }
    
    }

}
