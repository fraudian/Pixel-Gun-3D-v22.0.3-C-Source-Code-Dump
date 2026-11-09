using UnityEngine;

namespace Org.BouncyCastle.Security.Certificates
{
    [Serializable]
    public class CertificateParsingException : CertificateException
    {
        // Methods
        public CertificateParsingException()
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException();
        }
        public CertificateParsingException(string message)
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException(message:  message);
        }
        public CertificateParsingException(string message, System.Exception exception)
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException(message:  message, exception:  exception);
        }
    
    }

}
