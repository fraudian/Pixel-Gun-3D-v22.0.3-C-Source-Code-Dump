using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class DsaKeyGenerationParameters : KeyGenerationParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters;
        
        // Properties
        public Org.BouncyCastle.Crypto.Parameters.DsaParameters Parameters { get; }
        
        // Methods
        public DsaKeyGenerationParameters(Org.BouncyCastle.Security.SecureRandom random, Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters)
        {
            parameters = parameters.P.BitLength - 1;
            this.parameters = parameters;
        }
        public Org.BouncyCastle.Crypto.Parameters.DsaParameters get_Parameters()
        {
            return (Org.BouncyCastle.Crypto.Parameters.DsaParameters)this.parameters;
        }
    
    }

}
