using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class ElGamalKeyGenerationParameters : KeyGenerationParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters;
        
        // Properties
        public Org.BouncyCastle.Crypto.Parameters.ElGamalParameters Parameters { get; }
        
        // Methods
        public ElGamalKeyGenerationParameters(Org.BouncyCastle.Security.SecureRandom random, Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters)
        {
            int val_1 = Org.BouncyCastle.Crypto.Parameters.ElGamalKeyGenerationParameters.GetStrength(parameters:  parameters);
            this.parameters = parameters;
        }
        public Org.BouncyCastle.Crypto.Parameters.ElGamalParameters get_Parameters()
        {
            return (Org.BouncyCastle.Crypto.Parameters.ElGamalParameters)this.parameters;
        }
        internal static int GetStrength(Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters)
        {
            int val_1;
            if(parameters != null)
            {
                    val_1 = parameters.l;
                if(val_1 != 0)
            {
                    return (int)val_1;
            }
            
            }
            else
            {
                    if(64 != 0)
            {
                    val_1 = 64;
                return (int)val_1;
            }
            
            }
            
            if(parameters.p != null)
            {
                    return parameters.p.BitLength;
            }
            
            return parameters.p.BitLength;
        }
    
    }

}
