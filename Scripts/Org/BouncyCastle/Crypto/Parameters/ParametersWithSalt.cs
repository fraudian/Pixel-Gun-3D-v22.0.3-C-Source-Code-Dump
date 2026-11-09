using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class ParametersWithSalt : ICipherParameters
    {
        // Fields
        private byte[] salt;
        private Org.BouncyCastle.Crypto.ICipherParameters parameters;
        
        // Properties
        public Org.BouncyCastle.Crypto.ICipherParameters Parameters { get; }
        
        // Methods
        public ParametersWithSalt(Org.BouncyCastle.Crypto.ICipherParameters parameters, byte[] salt)
        {
            if(salt != null)
            {
                    return;
            }
        
        }
        public ParametersWithSalt(Org.BouncyCastle.Crypto.ICipherParameters parameters, byte[] salt, int saltOff, int saltLen)
        {
            byte[] val_1 = new byte[0];
            this.salt = val_1;
            this.parameters = parameters;
            System.Array.Copy(sourceArray:  salt, sourceIndex:  saltOff, destinationArray:  val_1, destinationIndex:  0, length:  saltLen);
        }
        public byte[] GetSalt()
        {
            return (System.Byte[])this.salt;
        }
        public Org.BouncyCastle.Crypto.ICipherParameters get_Parameters()
        {
            return (Org.BouncyCastle.Crypto.ICipherParameters)this.parameters;
        }
    
    }

}
