using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class AbstractTlsPeer : TlsPeer
    {
        // Methods
        public virtual bool ShouldUseGmtUnixTime()
        {
            return false;
        }
        public virtual void NotifySecureRenegotiation(bool secureRenegotiation)
        {
            if(secureRenegotiation != false)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  40);
        }
        public abstract Org.BouncyCastle.Crypto.Tls.TlsCompression GetCompression(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.TlsCipher GetCipher(); // 0
        public virtual void NotifyAlertRaised(byte alertLevel, byte alertDescription, string message, System.Exception cause)
        {
        
        }
        public virtual void NotifyAlertReceived(byte alertLevel, byte alertDescription)
        {
        
        }
        public virtual void NotifyHandshakeComplete()
        {
        
        }
        protected AbstractTlsPeer()
        {
        
        }
    
    }

}
