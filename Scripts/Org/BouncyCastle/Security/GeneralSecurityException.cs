using UnityEngine;

namespace Org.BouncyCastle.Security
{
    [Serializable]
    public class GeneralSecurityException : Exception
    {
        // Methods
        public GeneralSecurityException()
        {
        
        }
        public GeneralSecurityException(string message)
        {
        
        }
        public GeneralSecurityException(string message, System.Exception exception)
        {
            System.Exception val_1 = exception;
            val_1 = new System.Exception(message:  message, innerException:  val_1);
        }
    
    }

}
