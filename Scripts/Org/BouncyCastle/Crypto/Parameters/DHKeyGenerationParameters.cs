using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class DHKeyGenerationParameters : KeyGenerationParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Parameters.DHParameters parameters;
        
        // Properties
        public Org.BouncyCastle.Crypto.Parameters.DHParameters Parameters { get; }
        
        // Methods
        public DHKeyGenerationParameters(Org.BouncyCastle.Security.SecureRandom random, Org.BouncyCastle.Crypto.Parameters.DHParameters parameters)
        {
            int val_1 = Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters.GetStrength(parameters:  parameters);
            this.parameters = parameters;
        }
        public Org.BouncyCastle.Crypto.Parameters.DHParameters get_Parameters()
        {
            return (Org.BouncyCastle.Crypto.Parameters.DHParameters)this.parameters;
        }
        internal static int GetStrength(Org.BouncyCastle.Crypto.Parameters.DHParameters parameters)
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
                    if(3670080 != 0)
            {
                    val_1 = 3670080;
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
