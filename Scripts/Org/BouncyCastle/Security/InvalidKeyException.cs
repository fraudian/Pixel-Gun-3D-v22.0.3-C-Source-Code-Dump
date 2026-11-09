using UnityEngine;

namespace Org.BouncyCastle.Security
{
    [Serializable]
    public class InvalidKeyException : KeyException
    {
        // Methods
        public InvalidKeyException()
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException();
        }
        public InvalidKeyException(string message)
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException(message:  message);
        }
        public InvalidKeyException(string message, System.Exception exception)
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException(message:  message, exception:  exception);
        }
    
    }

}
