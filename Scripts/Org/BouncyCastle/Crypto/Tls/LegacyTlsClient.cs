using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public sealed class LegacyTlsClient : DefaultTlsClient
    {
        // Fields
        private readonly System.Uri TargetUri;
        private readonly Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer verifyer;
        private readonly Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider credProvider;
        
        // Methods
        public LegacyTlsClient(System.Uri targetUri, Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer verifyer, Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider prov, System.Collections.Generic.List<string> hostNames)
        {
            this.TargetUri = targetUri;
            this.verifyer = verifyer;
            this.credProvider = prov;
            this.HostNames = hostNames;
        }
        public override Org.BouncyCastle.Crypto.Tls.TlsAuthentication GetAuthentication()
        {
            .TargetUri = this.TargetUri;
            .verifyer = this.verifyer;
            return (Org.BouncyCastle.Crypto.Tls.TlsAuthentication)new Org.BouncyCastle.Crypto.Tls.LegacyTlsAuthentication();
        }
    
    }

}
