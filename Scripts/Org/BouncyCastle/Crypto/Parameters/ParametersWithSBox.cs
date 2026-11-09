using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class ParametersWithSBox : ICipherParameters
    {
        // Fields
        private Org.BouncyCastle.Crypto.ICipherParameters parameters;
        private byte[] sBox;
        
        // Properties
        public Org.BouncyCastle.Crypto.ICipherParameters Parameters { get; }
        
        // Methods
        public ParametersWithSBox(Org.BouncyCastle.Crypto.ICipherParameters parameters, byte[] sBox)
        {
            this.parameters = parameters;
            this.sBox = sBox;
        }
        public byte[] GetSBox()
        {
            return (System.Byte[])this.sBox;
        }
        public Org.BouncyCastle.Crypto.ICipherParameters get_Parameters()
        {
            return (Org.BouncyCastle.Crypto.ICipherParameters)this.parameters;
        }
    
    }

}
