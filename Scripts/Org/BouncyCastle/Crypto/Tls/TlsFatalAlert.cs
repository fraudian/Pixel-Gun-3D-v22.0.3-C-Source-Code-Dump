using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class TlsFatalAlert : IOException
    {
        // Fields
        private readonly byte alertDescription;
        
        // Properties
        public virtual byte AlertDescription { get; }
        
        // Methods
        public TlsFatalAlert(byte alertDescription)
        {
            string val_1 = Org.BouncyCastle.Crypto.Tls.AlertDescription.GetText(alertDescription:  alertDescription);
            this.alertDescription = alertDescription;
        }
        public TlsFatalAlert(byte alertDescription, System.Exception alertCause)
        {
            string val_1 = Org.BouncyCastle.Crypto.Tls.AlertDescription.GetText(alertDescription:  alertDescription);
            this.alertDescription = alertDescription;
        }
        public virtual byte get_AlertDescription()
        {
            return (byte)this.alertDescription;
        }
    
    }

}
