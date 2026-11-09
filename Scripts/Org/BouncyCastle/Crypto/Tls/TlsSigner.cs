using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsSigner
    {
        // Methods
        public abstract void Init(Org.BouncyCastle.Crypto.Tls.TlsContext context); // 0
        public abstract byte[] GenerateRawSignature(Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] md5AndSha1); // 0
        public abstract byte[] GenerateRawSignature(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] hash); // 0
        public abstract bool VerifyRawSignature(byte[] sigBytes, Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, byte[] md5AndSha1); // 0
        public abstract bool VerifyRawSignature(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, byte[] sigBytes, Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, byte[] hash); // 0
        public abstract Org.BouncyCastle.Crypto.ISigner CreateSigner(Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey); // 0
        public abstract Org.BouncyCastle.Crypto.ISigner CreateSigner(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey); // 0
        public abstract Org.BouncyCastle.Crypto.ISigner CreateVerifyer(Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey); // 0
        public abstract Org.BouncyCastle.Crypto.ISigner CreateVerifyer(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey); // 0
        public abstract bool IsValidPublicKey(Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey); // 0
    
    }

}
