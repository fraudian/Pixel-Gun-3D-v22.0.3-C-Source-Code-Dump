using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsClient : TlsPeer
    {
        // Properties
        public abstract System.Collections.Generic.List<string> HostNames { get; set; }
        public abstract Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientHelloRecordLayerVersion { get; }
        public abstract Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientVersion { get; }
        public abstract bool IsFallback { get; }
        
        // Methods
        public abstract System.Collections.Generic.List<string> get_HostNames(); // 0
        public abstract void set_HostNames(System.Collections.Generic.List<string> value); // 0
        public abstract void Init(Org.BouncyCastle.Crypto.Tls.TlsClientContext context); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.TlsSession GetSessionToResume(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.ProtocolVersion get_ClientHelloRecordLayerVersion(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.ProtocolVersion get_ClientVersion(); // 0
        public abstract bool get_IsFallback(); // 0
        public abstract int[] GetCipherSuites(); // 0
        public abstract byte[] GetCompressionMethods(); // 0
        public abstract System.Collections.IDictionary GetClientExtensions(); // 0
        public abstract void NotifyServerVersion(Org.BouncyCastle.Crypto.Tls.ProtocolVersion selectedVersion); // 0
        public abstract void NotifySessionID(byte[] sessionID); // 0
        public abstract void NotifySelectedCipherSuite(int selectedCipherSuite); // 0
        public abstract void NotifySelectedCompressionMethod(byte selectedCompressionMethod); // 0
        public abstract void ProcessServerExtensions(System.Collections.IDictionary serverExtensions); // 0
        public abstract void ProcessServerSupplementalData(System.Collections.IList serverSupplementalData); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.TlsKeyExchange GetKeyExchange(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.TlsAuthentication GetAuthentication(); // 0
        public abstract System.Collections.IList GetClientSupplementalData(); // 0
        public abstract void NotifyNewSessionTicket(Org.BouncyCastle.Crypto.Tls.NewSessionTicket newSessionTicket); // 0
    
    }

}
