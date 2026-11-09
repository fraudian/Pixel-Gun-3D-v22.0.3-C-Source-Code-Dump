using UnityEngine;

namespace Org.BouncyCastle.Security.Certificates
{
    [Serializable]
    public class CertificateExpiredException : CertificateException
    {
        // Methods
        public CertificateExpiredException()
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException();
        }
        public CertificateExpiredException(string message)
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException(message:  message);
        }
        public CertificateExpiredException(string message, System.Exception exception)
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException(message:  message, exception:  exception);
        }
    
    }

}
