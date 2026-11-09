using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class Gost3410PrivateKeyParameters : Gost3410KeyParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger x;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger X { get; }
        
        // Methods
        public Gost3410PrivateKeyParameters(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters parameters)
        {
            this = new Org.BouncyCastle.Crypto.AsymmetricKeyParameter(privateKey:  true);
            mem[1152921551360626472] = parameters;
            if((x.SignValue >= 1) && (x.BitLength <= 256))
            {
                    if(((x.CompareTo(value:  parameters.q)) & 2147483648) != 0)
            {
                    this.x = x;
                return;
            }
            
            }
            
            System.ArgumentException val_5 = new System.ArgumentException(message:  "Invalid x for GOST3410 private key", paramName:  "x");
        }
        public Gost3410PrivateKeyParameters(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet)
        {
            this = new Org.BouncyCastle.Crypto.AsymmetricKeyParameter(privateKey:  true);
            mem[1152921551360809128] = Org.BouncyCastle.Crypto.Parameters.Gost3410KeyParameters.LookupParameters(publicKeyParamSet:  publicKeyParamSet);
            mem[1152921551360809136] = publicKeyParamSet;
            if((x.SignValue >= 1) && (x.BitLength <= 256))
            {
                    if(((x.CompareTo(value:  publicKeyParamSet.body)) & 2147483648) != 0)
            {
                    this.x = x;
                return;
            }
            
            }
            
            System.ArgumentException val_6 = new System.ArgumentException(message:  "Invalid x for GOST3410 private key", paramName:  "x");
        }
        public Org.BouncyCastle.Math.BigInteger get_X()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.x;
        }
    
    }

}
