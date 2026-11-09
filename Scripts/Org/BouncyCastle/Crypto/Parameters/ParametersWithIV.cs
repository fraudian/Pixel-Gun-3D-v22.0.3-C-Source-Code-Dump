using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class ParametersWithIV : ICipherParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.ICipherParameters parameters;
        private readonly byte[] iv;
        
        // Properties
        public Org.BouncyCastle.Crypto.ICipherParameters Parameters { get; }
        
        // Methods
        public ParametersWithIV(Org.BouncyCastle.Crypto.ICipherParameters parameters, byte[] iv)
        {
            if(iv != null)
            {
                    return;
            }
        
        }
        public ParametersWithIV(Org.BouncyCastle.Crypto.ICipherParameters parameters, byte[] iv, int ivOff, int ivLen)
        {
            if(iv != null)
            {
                    this.parameters = parameters;
                byte[] val_1 = new byte[0];
                this.iv = val_1;
                System.Array.Copy(sourceArray:  iv, sourceIndex:  ivOff, destinationArray:  val_1, destinationIndex:  0, length:  ivLen);
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "iv");
        }
        public byte[] GetIV()
        {
            System.Byte[] val_3;
            var val_4;
            val_3 = this.iv;
            object val_1 = val_3.Clone();
            if(val_1 == null)
            {
                    return (System.Byte[])val_4;
            }
            
            val_4 = val_1;
            val_3 = null;
            if(val_4 != null)
            {
                    return (System.Byte[])val_4;
            }
            
            val_4 = 0;
            return (System.Byte[])val_4;
        }
        public Org.BouncyCastle.Crypto.ICipherParameters get_Parameters()
        {
            return (Org.BouncyCastle.Crypto.ICipherParameters)this.parameters;
        }
    
    }

}
