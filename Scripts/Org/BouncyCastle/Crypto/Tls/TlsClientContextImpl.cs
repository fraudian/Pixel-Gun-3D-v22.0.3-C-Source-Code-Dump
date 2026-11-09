using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    internal class TlsClientContextImpl : AbstractTlsContext, TlsClientContext, TlsContext
    {
        // Properties
        public override bool IsServer { get; }
        
        // Methods
        internal TlsClientContextImpl(Org.BouncyCastle.Security.SecureRandom secureRandom, Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters)
        {
        
        }
        public override bool get_IsServer()
        {
            return false;
        }
    
    }

}
