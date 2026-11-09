using UnityEngine;

namespace Org.BouncyCastle.Security.Certificates
{
    [Serializable]
    public class CertificateNotYetValidException : CertificateException
    {
        // Methods
        public CertificateNotYetValidException()
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException();
        }
        public CertificateNotYetValidException(string message)
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException(message:  message);
        }
        public CertificateNotYetValidException(string message, System.Exception exception)
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException(message:  message, exception:  exception);
        }
    
    }

}
