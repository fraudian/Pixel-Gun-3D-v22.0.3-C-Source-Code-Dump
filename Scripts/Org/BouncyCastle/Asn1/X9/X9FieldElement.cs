using UnityEngine;

namespace Org.BouncyCastle.Asn1.X9
{
    public class X9FieldElement : Asn1Encodable
    {
        // Fields
        private Org.BouncyCastle.Math.EC.ECFieldElement f;
        
        // Properties
        public Org.BouncyCastle.Math.EC.ECFieldElement Value { get; }
        
        // Methods
        public X9FieldElement(Org.BouncyCastle.Math.EC.ECFieldElement f)
        {
            this.f = f;
        }
        public X9FieldElement(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Asn1.Asn1OctetString s)
        {
            this.f = new Org.BouncyCastle.Math.EC.FpFieldElement(q:  p, x:  new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  s));
        }
        public X9FieldElement(int m, int k1, int k2, int k3, Org.BouncyCastle.Asn1.Asn1OctetString s)
        {
            this.f = new Org.BouncyCastle.Math.EC.F2mFieldElement(m:  m, k1:  k1, k2:  k2, k3:  k3, x:  new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  s));
        }
        public Org.BouncyCastle.Math.EC.ECFieldElement get_Value()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)this.f;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Math.EC.ECFieldElement val_1 = this.f + 7;
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerOctetString(str:  Org.BouncyCastle.Asn1.X9.X9IntegerConverter.IntegerToBytes(s:  this.f, qLength:  ((val_1 < 0) ? (this.f + 14) : (val_1)) >> 3));
        }
    
    }

}
