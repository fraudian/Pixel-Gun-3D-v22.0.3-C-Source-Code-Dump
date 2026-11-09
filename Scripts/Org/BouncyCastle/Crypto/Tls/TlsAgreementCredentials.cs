using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsAgreementCredentials : TlsCredentials
    {
        // Methods
        public abstract byte[] GenerateAgreement(Org.BouncyCastle.Crypto.AsymmetricKeyParameter peerPublicKey); // 0
    
    }

}
