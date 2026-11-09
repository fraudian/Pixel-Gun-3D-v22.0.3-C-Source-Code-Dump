using UnityEngine;

namespace Org.BouncyCastle.Security.Certificates
{
    [Serializable]
    public class CertificateEncodingException : CertificateException
    {
        // Methods
        public CertificateEncodingException()
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException();
        }
        public CertificateEncodingException(string msg)
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException(message:  msg);
        }
        public CertificateEncodingException(string msg, System.Exception e)
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException(message:  msg, exception:  e);
        }
    
    }

}
