using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsServer : TlsPeer
    {
        // Methods
        public abstract void Init(Org.BouncyCastle.Crypto.Tls.TlsServerContext context); // 0
        public abstract void NotifyClientVersion(Org.BouncyCastle.Crypto.Tls.ProtocolVersion clientVersion); // 0
        public abstract void NotifyFallback(bool isFallback); // 0
        public abstract void NotifyOfferedCipherSuites(int[] offeredCipherSuites); // 0
        public abstract void NotifyOfferedCompressionMethods(byte[] offeredCompressionMethods); // 0
        public abstract void ProcessClientExtensions(System.Collections.IDictionary clientExtensions); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.ProtocolVersion GetServerVersion(); // 0
        public abstract int GetSelectedCipherSuite(); // 0
        public abstract byte GetSelectedCompressionMethod(); // 0
        public abstract System.Collections.IDictionary GetServerExtensions(); // 0
        public abstract System.Collections.IList GetServerSupplementalData(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.TlsCredentials GetCredentials(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.CertificateStatus GetCertificateStatus(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.TlsKeyExchange GetKeyExchange(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.CertificateRequest GetCertificateRequest(); // 0
        public abstract void ProcessClientSupplementalData(System.Collections.IList clientSupplementalData); // 0
        public abstract void NotifyClientCertificate(Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.NewSessionTicket GetNewSessionTicket(); // 0
    
    }

}
