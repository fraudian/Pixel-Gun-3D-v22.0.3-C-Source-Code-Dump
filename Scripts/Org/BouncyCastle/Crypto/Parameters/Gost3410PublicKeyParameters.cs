using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class Gost3410PublicKeyParameters : Gost3410KeyParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger y;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger Y { get; }
        
        // Methods
        public Gost3410PublicKeyParameters(Org.BouncyCastle.Math.BigInteger y, Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters parameters)
        {
            this = new Org.BouncyCastle.Crypto.AsymmetricKeyParameter(privateKey:  false);
            mem[1152921551361112120] = parameters;
            if(y.SignValue >= 1)
            {
                    if(((y.CompareTo(value:  parameters.p)) & 2147483648) != 0)
            {
                    this.y = y;
                return;
            }
            
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "Invalid y for GOST3410 public key", paramName:  "y");
        }
        public Gost3410PublicKeyParameters(Org.BouncyCastle.Math.BigInteger y, Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet)
        {
            this = new Org.BouncyCastle.Crypto.AsymmetricKeyParameter(privateKey:  false);
            mem[1152921551361262008] = Org.BouncyCastle.Crypto.Parameters.Gost3410KeyParameters.LookupParameters(publicKeyParamSet:  publicKeyParamSet);
            mem[1152921551361262016] = publicKeyParamSet;
            if(y.SignValue >= 1)
            {
                    if(((y.CompareTo(value:  publicKeyParamSet.identifier)) & 2147483648) != 0)
            {
                    this.y = y;
                return;
            }
            
            }
            
            System.ArgumentException val_5 = new System.ArgumentException(message:  "Invalid y for GOST3410 public key", paramName:  "y");
        }
        public Org.BouncyCastle.Math.BigInteger get_Y()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.y;
        }
    
    }

}
