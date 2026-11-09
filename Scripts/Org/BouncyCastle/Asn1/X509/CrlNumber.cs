using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class CrlNumber : DerInteger
    {
        // Properties
        public Org.BouncyCastle.Math.BigInteger Number { get; }
        
        // Methods
        public CrlNumber(Org.BouncyCastle.Math.BigInteger number)
        {
        
        }
        public Org.BouncyCastle.Math.BigInteger get_Number()
        {
            return this.PositiveValue;
        }
        public override string ToString()
        {
            return "CRLNumber: "("CRLNumber: ") + this.PositiveValue;
        }
    
    }

}
