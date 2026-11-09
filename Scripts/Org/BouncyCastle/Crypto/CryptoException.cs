using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    [Serializable]
    public class CryptoException : Exception
    {
        // Methods
        public CryptoException()
        {
        
        }
        public CryptoException(string message)
        {
        
        }
        public CryptoException(string message, System.Exception exception)
        {
            System.Exception val_1 = exception;
            val_1 = new System.Exception(message:  message, innerException:  val_1);
        }
    
    }

}
