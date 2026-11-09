using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class AbstractTlsSigner : TlsSigner
    {
        // Fields
        protected Org.BouncyCastle.Crypto.Tls.TlsContext mContext;
        
        // Methods
        public virtual void Init(Org.BouncyCastle.Crypto.Tls.TlsContext context)
        {
            this.mContext = context;
        }
        public virtual byte[] GenerateRawSignature(Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] md5AndSha1)
        {
            goto typeof(Org.BouncyCastle.Crypto.Tls.AbstractTlsSigner).__il2cppRuntimeField_228;
        }
        public abstract byte[] GenerateRawSignature(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] hash); // 0
        public virtual bool VerifyRawSignature(byte[] sigBytes, Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, byte[] md5AndSha1)
        {
            goto typeof(Org.BouncyCastle.Crypto.Tls.AbstractTlsSigner).__il2cppRuntimeField_248;
        }
        public abstract bool VerifyRawSignature(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, byte[] sigBytes, Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, byte[] hash); // 0
        public virtual Org.BouncyCastle.Crypto.ISigner CreateSigner(Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
        {
            goto typeof(Org.BouncyCastle.Crypto.Tls.AbstractTlsSigner).__il2cppRuntimeField_268;
        }
        public abstract Org.BouncyCastle.Crypto.ISigner CreateSigner(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey); // 0
        public virtual Org.BouncyCastle.Crypto.ISigner CreateVerifyer(Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
        {
            goto typeof(Org.BouncyCastle.Crypto.Tls.AbstractTlsSigner).__il2cppRuntimeField_288;
        }
        public abstract Org.BouncyCastle.Crypto.ISigner CreateVerifyer(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey); // 0
        public abstract bool IsValidPublicKey(Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey); // 0
        protected AbstractTlsSigner()
        {
        
        }
    
    }

}
