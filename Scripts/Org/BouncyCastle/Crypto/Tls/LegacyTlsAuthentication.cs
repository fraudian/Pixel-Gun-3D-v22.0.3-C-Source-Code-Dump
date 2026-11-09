using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class LegacyTlsAuthentication : TlsAuthentication
    {
        // Fields
        protected Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer verifyer;
        protected Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider credProvider;
        protected System.Uri TargetUri;
        
        // Methods
        public LegacyTlsAuthentication(System.Uri targetUri, Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer verifyer, Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider prov)
        {
            this.credProvider = prov;
            this.TargetUri = targetUri;
            this.verifyer = verifyer;
        }
        public virtual void NotifyServerCertificate(Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            if((this.verifyer.IsValid(targetUri:  this.TargetUri, certs:  serverCertificate)) != false)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_3 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  90);
        }
        public virtual Org.BouncyCastle.Crypto.Tls.TlsCredentials GetClientCredentials(Org.BouncyCastle.Crypto.Tls.TlsContext context, Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest)
        {
            if(this.credProvider == null)
            {
                    return 0;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.credProvider.GetClientCredentials(context:  context, certificateRequest:  certificateRequest);
        }
    
    }

}
