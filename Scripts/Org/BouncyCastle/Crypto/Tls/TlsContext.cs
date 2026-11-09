using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsContext
    {
        // Properties
        public abstract Org.BouncyCastle.Crypto.Prng.IRandomGenerator NonceRandomGenerator { get; }
        public abstract Org.BouncyCastle.Security.SecureRandom SecureRandom { get; }
        public abstract Org.BouncyCastle.Crypto.Tls.SecurityParameters SecurityParameters { get; }
        public abstract bool IsServer { get; }
        public abstract Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientVersion { get; }
        public abstract Org.BouncyCastle.Crypto.Tls.ProtocolVersion ServerVersion { get; }
        public abstract Org.BouncyCastle.Crypto.Tls.TlsSession ResumableSession { get; }
        public abstract object UserObject { get; set; }
        
        // Methods
        public abstract Org.BouncyCastle.Crypto.Prng.IRandomGenerator get_NonceRandomGenerator(); // 0
        public abstract Org.BouncyCastle.Security.SecureRandom get_SecureRandom(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.SecurityParameters get_SecurityParameters(); // 0
        public abstract bool get_IsServer(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.ProtocolVersion get_ClientVersion(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.ProtocolVersion get_ServerVersion(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.TlsSession get_ResumableSession(); // 0
        public abstract object get_UserObject(); // 0
        public abstract void set_UserObject(object value); // 0
        public abstract byte[] ExportKeyingMaterial(string asciiLabel, byte[] context_value, int length); // 0
    
    }

}
