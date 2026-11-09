using UnityEngine;

namespace Org.BouncyCastle.Security
{
    [Serializable]
    public class SecurityUtilityException : Exception
    {
        // Methods
        public SecurityUtilityException()
        {
        
        }
        public SecurityUtilityException(string message)
        {
        
        }
        public SecurityUtilityException(string message, System.Exception exception)
        {
            System.Exception val_1 = exception;
            val_1 = new System.Exception(message:  message, innerException:  val_1);
        }
    
    }

}
