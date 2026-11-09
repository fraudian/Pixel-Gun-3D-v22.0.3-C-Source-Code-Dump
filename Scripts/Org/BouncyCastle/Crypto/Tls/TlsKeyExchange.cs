using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsKeyExchange
    {
        // Properties
        public abstract bool RequiresServerKeyExchange { get; }
        
        // Methods
        public abstract void Init(Org.BouncyCastle.Crypto.Tls.TlsContext context); // 0
        public abstract void SkipServerCredentials(); // 0
        public abstract void ProcessServerCredentials(Org.BouncyCastle.Crypto.Tls.TlsCredentials serverCredentials); // 0
        public abstract void ProcessServerCertificate(Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate); // 0
        public abstract bool get_RequiresServerKeyExchange(); // 0
        public abstract byte[] GenerateServerKeyExchange(); // 0
        public abstract void SkipServerKeyExchange(); // 0
        public abstract void ProcessServerKeyExchange(System.IO.Stream input); // 0
        public abstract void ValidateCertificateRequest(Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest); // 0
        public abstract void SkipClientCredentials(); // 0
        public abstract void ProcessClientCredentials(Org.BouncyCastle.Crypto.Tls.TlsCredentials clientCredentials); // 0
        public abstract void ProcessClientCertificate(Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate); // 0
        public abstract void GenerateClientKeyExchange(System.IO.Stream output); // 0
        public abstract void ProcessClientKeyExchange(System.IO.Stream input); // 0
        public abstract byte[] GeneratePremasterSecret(); // 0
    
    }

}
