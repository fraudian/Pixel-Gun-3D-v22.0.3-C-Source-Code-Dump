using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class TlsNullCipher : TlsCipher
    {
        // Fields
        protected readonly Org.BouncyCastle.Crypto.Tls.TlsContext context;
        protected readonly Org.BouncyCastle.Crypto.Tls.TlsMac writeMac;
        protected readonly Org.BouncyCastle.Crypto.Tls.TlsMac readMac;
        
        // Methods
        public TlsNullCipher(Org.BouncyCastle.Crypto.Tls.TlsContext context)
        {
            this.writeMac = 0;
            this.readMac = 0;
            this.context = context;
        }
        public TlsNullCipher(Org.BouncyCastle.Crypto.Tls.TlsContext context, Org.BouncyCastle.Crypto.IDigest clientWriteDigest, Org.BouncyCastle.Crypto.IDigest serverWriteDigest)
        {
            int val_17;
            Org.BouncyCastle.Crypto.IDigest val_18;
            var val_20;
            val_18 = clientWriteDigest;
            if(((val_18 == 0) ? 1 : 0) != ((serverWriteDigest == 0) ? 1 : 0))
            {
                goto label_34;
            }
            
            this.context = context;
            if(val_18 == null)
            {
                goto label_2;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            goto label_6;
            label_2:
            val_20 = 0;
            if(context != null)
            {
                goto label_35;
            }
            
            goto label_8;
            label_6:
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_17 = serverWriteDigest.GetDigestSize() + val_18.GetDigestSize();
            System.Byte[] val_7 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateKeyBlock(context:  context, size:  val_17);
            var val_26 = 0;
            val_26 = val_26 + 1;
            Org.BouncyCastle.Crypto.Tls.TlsMac val_10 = null;
            val_20 = val_10;
            val_10 = new Org.BouncyCastle.Crypto.Tls.TlsMac(context:  context, digest:  val_18, key:  val_7, keyOff:  0, keyLen:  val_18.GetDigestSize());
            var val_27 = 0;
            val_27 = val_27 + 1;
            int val_12 = val_18.GetDigestSize();
            var val_28 = 0;
            val_28 = val_28 + 1;
            Org.BouncyCastle.Crypto.Tls.TlsMac val_15 = null;
            val_18 = val_15;
            val_15 = new Org.BouncyCastle.Crypto.Tls.TlsMac(context:  context, digest:  serverWriteDigest, key:  val_7, keyOff:  val_12, keyLen:  serverWriteDigest.GetDigestSize());
            var val_29 = 0;
            val_29 = val_29 + 1;
            if((serverWriteDigest.GetDigestSize() + val_12) != val_17)
            {
                goto label_34;
            }
            
            if(context != null)
            {
                goto label_35;
            }
            
            label_8:
            label_35:
            var val_30 = 0;
            val_30 = val_30 + 1;
            bool val_20 = context.IsServer;
            this.writeMac = (val_20 != true) ? (val_18) : (val_20);
            this.readMac = (val_20 != true) ? (val_20) : (val_18);
            return;
            label_34:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_23 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public virtual int GetPlaintextLimit(int ciphertextLimit)
        {
            int val_1 = ciphertextLimit;
            if(this.writeMac == null)
            {
                    return (int)val_1;
            }
            
            val_1 = val_1 - this.writeMac;
            return (int)val_1;
        }
        public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
        {
            if(this.writeMac == null)
            {
                    return Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  plaintext, from:  offset, to:  len + offset);
            }
            
            byte[] val_1 = new byte[0];
            System.Array.Copy(sourceArray:  plaintext, sourceIndex:  offset, destinationArray:  val_1, destinationIndex:  0, length:  len);
            System.Array.Copy(sourceArray:  this.writeMac, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  len, length:  this.writeMac.secret);
            return (System.Byte[])val_1;
        }
        public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
        {
            var val_8;
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_9;
            var val_10;
            if(this.readMac == null)
            {
                goto label_1;
            }
            
            if(this.readMac > len)
            {
                goto label_2;
            }
            
            val_8 = len - this.readMac;
            if((Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a:  Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  ciphertext, from:  val_8 + offset, to:  len + offset), b:  this.readMac)) == true)
            {
                    return Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  ciphertext, from:  offset, to:  val_8 + offset);
            }
            
            val_9 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_10 = 20;
            goto label_5;
            label_1:
            val_8 = len;
            return Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  ciphertext, from:  offset, to:  val_8 + offset);
            label_2:
            val_9 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_10 = 50;
            label_5:
            val_9 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  50);
        }
    
    }

}
