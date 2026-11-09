using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class DefaultTlsCipherFactory : AbstractTlsCipherFactory
    {
        // Methods
        public override Org.BouncyCastle.Crypto.Tls.TlsCipher CreateCipher(Org.BouncyCastle.Crypto.Tls.TlsContext context, int encryptionAlgorithm, int macAlgorithm)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_9 = macAlgorithm;
            val_10 = context;
            val_11 = this;
            if(encryptionAlgorithm > 101)
            {
                goto label_1;
            }
            
            if(encryptionAlgorithm > 20)
            {
                goto label_6;
            }
            
            var val_9 = 106048792 + (encryptionAlgorithm) << 2;
            val_9 = val_9 + 106048792;
            goto (106048792 + (encryptionAlgorithm) << 2 + 106048792);
            label_1:
            if(encryptionAlgorithm == 102)
            {
                goto label_4;
            }
            
            if(encryptionAlgorithm == 103)
            {
                goto label_5;
            }
            
            if(encryptionAlgorithm != 104)
            {
                goto label_6;
            }
            
            goto label_7;
            label_4:
            val_11 = ???;
            val_10 = ???;
            val_9 = ???;
            goto typeof(Org.BouncyCastle.Crypto.Tls.DefaultTlsCipherFactory).__il2cppRuntimeField_1A8;
            label_5:
            val_12 = mem[val_11];
            val_12 = val_11;
            label_7:
            val_13 = val_11;
            return (Org.BouncyCastle.Crypto.Tls.TlsCipher)val_13;
            label_6:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_8 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsBlockCipher CreateAESCipher(Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macAlgorithm)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsBlockCipher)new Org.BouncyCastle.Crypto.Tls.TlsBlockCipher(context:  context, clientWriteCipher:  this, serverWriteCipher:  this, clientWriteDigest:  this, serverWriteDigest:  this, cipherKeySize:  cipherKeySize);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsBlockCipher CreateCamelliaCipher(Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macAlgorithm)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsBlockCipher)new Org.BouncyCastle.Crypto.Tls.TlsBlockCipher(context:  context, clientWriteCipher:  this, serverWriteCipher:  this, clientWriteDigest:  this, serverWriteDigest:  this, cipherKeySize:  cipherKeySize);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsCipher CreateChaCha20Poly1305(Org.BouncyCastle.Crypto.Tls.TlsContext context)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsCipher)new Org.BouncyCastle.Crypto.Tls.Chacha20Poly1305(context:  context);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsAeadCipher CreateCipher_Aes_Ccm(Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macSize)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsAeadCipher)new Org.BouncyCastle.Crypto.Tls.TlsAeadCipher(context:  context, clientWriteCipher:  this, serverWriteCipher:  this, cipherKeySize:  cipherKeySize, macSize:  macSize);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsAeadCipher CreateCipher_Aes_Gcm(Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macSize)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsAeadCipher)new Org.BouncyCastle.Crypto.Tls.TlsAeadCipher(context:  context, clientWriteCipher:  this, serverWriteCipher:  this, cipherKeySize:  cipherKeySize, macSize:  macSize);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsAeadCipher CreateCipher_Aes_Ocb(Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macSize)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsAeadCipher)new Org.BouncyCastle.Crypto.Tls.TlsAeadCipher(context:  context, clientWriteCipher:  this, serverWriteCipher:  this, cipherKeySize:  cipherKeySize, macSize:  macSize, nonceMode:  2);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsAeadCipher CreateCipher_Camellia_Gcm(Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macSize)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsAeadCipher)new Org.BouncyCastle.Crypto.Tls.TlsAeadCipher(context:  context, clientWriteCipher:  this, serverWriteCipher:  this, cipherKeySize:  cipherKeySize, macSize:  macSize);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsBlockCipher CreateDesEdeCipher(Org.BouncyCastle.Crypto.Tls.TlsContext context, int macAlgorithm)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsBlockCipher)new Org.BouncyCastle.Crypto.Tls.TlsBlockCipher(context:  context, clientWriteCipher:  this, serverWriteCipher:  this, clientWriteDigest:  this, serverWriteDigest:  this, cipherKeySize:  24);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsNullCipher CreateNullCipher(Org.BouncyCastle.Crypto.Tls.TlsContext context, int macAlgorithm)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsNullCipher)new Org.BouncyCastle.Crypto.Tls.TlsNullCipher(context:  context, clientWriteDigest:  this, serverWriteDigest:  this);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsStreamCipher CreateRC4Cipher(Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macAlgorithm)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsStreamCipher)new Org.BouncyCastle.Crypto.Tls.TlsStreamCipher(context:  context, clientWriteCipher:  this, serverWriteCipher:  this, clientWriteDigest:  this, serverWriteDigest:  this, cipherKeySize:  cipherKeySize, usesNonce:  false);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsBlockCipher CreateSeedCipher(Org.BouncyCastle.Crypto.Tls.TlsContext context, int macAlgorithm)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsBlockCipher)new Org.BouncyCastle.Crypto.Tls.TlsBlockCipher(context:  context, clientWriteCipher:  this, serverWriteCipher:  this, clientWriteDigest:  this, serverWriteDigest:  this, cipherKeySize:  16);
        }
        protected virtual Org.BouncyCastle.Crypto.IBlockCipher CreateAesEngine()
        {
            return (Org.BouncyCastle.Crypto.IBlockCipher)new Org.BouncyCastle.Crypto.Engines.AesFastEngine();
        }
        protected virtual Org.BouncyCastle.Crypto.IBlockCipher CreateCamelliaEngine()
        {
            return (Org.BouncyCastle.Crypto.IBlockCipher)new Org.BouncyCastle.Crypto.Engines.CamelliaEngine();
        }
        protected virtual Org.BouncyCastle.Crypto.IBlockCipher CreateAesBlockCipher()
        {
            return (Org.BouncyCastle.Crypto.IBlockCipher)new Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(cipher:  this);
        }
        protected virtual Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateAeadBlockCipher_Aes_Ccm()
        {
            return (Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher)new Org.BouncyCastle.Crypto.Modes.CcmBlockCipher(cipher:  this);
        }
        protected virtual Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateAeadBlockCipher_Aes_Gcm()
        {
            return (Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher)new Org.BouncyCastle.Crypto.Modes.GcmBlockCipher(c:  this);
        }
        protected virtual Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateAeadBlockCipher_Aes_Ocb()
        {
            return (Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher)new Org.BouncyCastle.Crypto.Modes.OcbBlockCipher(hashCipher:  this, mainCipher:  this);
        }
        protected virtual Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateAeadBlockCipher_Camellia_Gcm()
        {
            return (Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher)new Org.BouncyCastle.Crypto.Modes.GcmBlockCipher(c:  this);
        }
        protected virtual Org.BouncyCastle.Crypto.IBlockCipher CreateCamelliaBlockCipher()
        {
            return (Org.BouncyCastle.Crypto.IBlockCipher)new Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(cipher:  this);
        }
        protected virtual Org.BouncyCastle.Crypto.IBlockCipher CreateDesEdeBlockCipher()
        {
            return (Org.BouncyCastle.Crypto.IBlockCipher)new Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(cipher:  new Org.BouncyCastle.Crypto.Engines.DesEdeEngine());
        }
        protected virtual Org.BouncyCastle.Crypto.IStreamCipher CreateRC4StreamCipher()
        {
            return (Org.BouncyCastle.Crypto.IStreamCipher)new Org.BouncyCastle.Crypto.Engines.RC4Engine();
        }
        protected virtual Org.BouncyCastle.Crypto.IBlockCipher CreateSeedBlockCipher()
        {
            return (Org.BouncyCastle.Crypto.IBlockCipher)new Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(cipher:  new Org.BouncyCastle.Crypto.Engines.SeedEngine());
        }
        protected virtual Org.BouncyCastle.Crypto.IDigest CreateHMacDigest(int macAlgorithm)
        {
            if(macAlgorithm <= 5)
            {
                    var val_6 = 106048876 + (macAlgorithm) << 2;
                val_6 = val_6 + 106048876;
            }
            else
            {
                    Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_5 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
            }
        
        }
        public DefaultTlsCipherFactory()
        {
            val_1 = new System.Object();
        }
    
    }

}
