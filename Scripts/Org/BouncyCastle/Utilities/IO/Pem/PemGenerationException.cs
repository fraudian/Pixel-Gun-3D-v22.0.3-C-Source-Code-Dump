using UnityEngine;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
    [Serializable]
    public class PemGenerationException : Exception
    {
        // Methods
        public PemGenerationException()
        {
        
        }
        public PemGenerationException(string message)
        {
        
        }
        public PemGenerationException(string message, System.Exception exception)
        {
            System.Exception val_1 = exception;
            val_1 = new System.Exception(message:  message, innerException:  val_1);
        }
    
    }

}
