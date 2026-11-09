using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class ParametersWithRandom : ICipherParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.ICipherParameters parameters;
        private readonly Org.BouncyCastle.Security.SecureRandom random;
        
        // Properties
        public Org.BouncyCastle.Security.SecureRandom Random { get; }
        public Org.BouncyCastle.Crypto.ICipherParameters Parameters { get; }
        
        // Methods
        public ParametersWithRandom(Org.BouncyCastle.Crypto.ICipherParameters parameters, Org.BouncyCastle.Security.SecureRandom random)
        {
            string val_4;
            val_1 = new System.Object();
            if(parameters == null)
            {
                goto label_1;
            }
            
            if(val_1 == null)
            {
                goto label_2;
            }
            
            this.parameters = parameters;
            this.random = val_1;
            return;
            label_1:
            val_4 = "parameters";
            goto label_3;
            label_2:
            val_4 = "random";
            label_3:
            null = new System.ArgumentNullException(paramName:  val_4);
        }
        public ParametersWithRandom(Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            Org.BouncyCastle.Security.SecureRandom val_1 = new Org.BouncyCastle.Security.SecureRandom();
        }
        public Org.BouncyCastle.Security.SecureRandom GetRandom()
        {
            return (Org.BouncyCastle.Security.SecureRandom)this.random;
        }
        public Org.BouncyCastle.Security.SecureRandom get_Random()
        {
            return (Org.BouncyCastle.Security.SecureRandom)this.random;
        }
        public Org.BouncyCastle.Crypto.ICipherParameters get_Parameters()
        {
            return (Org.BouncyCastle.Crypto.ICipherParameters)this.parameters;
        }
    
    }

}
