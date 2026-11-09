using UnityEngine;

namespace Org.BouncyCastle.Security
{
    [Serializable]
    public class InvalidParameterException : KeyException
    {
        // Methods
        public InvalidParameterException()
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException();
        }
        public InvalidParameterException(string message)
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException(message:  message);
        }
        public InvalidParameterException(string message, System.Exception exception)
        {
            val_1 = new Org.BouncyCastle.Security.GeneralSecurityException(message:  message, exception:  exception);
        }
    
    }

}
