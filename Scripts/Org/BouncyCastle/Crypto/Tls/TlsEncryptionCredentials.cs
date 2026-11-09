using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsEncryptionCredentials : TlsCredentials
    {
        // Methods
        public abstract byte[] DecryptPreMasterSecret(byte[] encryptedPreMasterSecret); // 0
    
    }

}
