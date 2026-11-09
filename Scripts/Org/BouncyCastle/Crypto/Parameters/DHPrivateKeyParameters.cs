using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class DHPrivateKeyParameters : DHKeyParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger x;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger X { get; }
        
        // Methods
        public DHPrivateKeyParameters(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Crypto.Parameters.DHParameters parameters)
        {
            this.x = x;
        }
        public DHPrivateKeyParameters(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Crypto.Parameters.DHParameters parameters, Org.BouncyCastle.Asn1.DerObjectIdentifier algorithmOid)
        {
            val_1 = new Org.BouncyCastle.Crypto.AsymmetricKeyParameter(privateKey:  true);
            mem[1152921551342123528] = parameters;
            mem[1152921551342123536] = algorithmOid;
            this.x = x;
        }
        public Org.BouncyCastle.Math.BigInteger get_X()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.x;
        }
        public override bool Equals(object obj)
        {
            var val_1;
            if(this != obj)
            {
                    val_1 = 0;
                return (bool)val_1;
            }
            
            val_1 = 1;
            return (bool)val_1;
        }
        protected bool Equals(Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters other)
        {
            if((this.x & 1) == 0)
            {
                    return false;
            }
            
            return other.Equals(other:  other);
        }
        public override int GetHashCode()
        {
            int val_1 = this.GetHashCode();
            val_1 = val_1 ^ this.x;
            return (int)val_1;
        }
    
    }

}
