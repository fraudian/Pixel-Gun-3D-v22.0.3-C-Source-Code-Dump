using UnityEngine;

namespace Org.BouncyCastle.Asn1.Oiw
{
    public class ElGamalParameter : Asn1Encodable
    {
        // Fields
        internal Org.BouncyCastle.Asn1.DerInteger p;
        internal Org.BouncyCastle.Asn1.DerInteger g;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger P { get; }
        public Org.BouncyCastle.Math.BigInteger G { get; }
        
        // Methods
        public ElGamalParameter(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger g)
        {
            this.p = new Org.BouncyCastle.Asn1.DerInteger(value:  p);
            this.g = new Org.BouncyCastle.Asn1.DerInteger(value:  g);
        }
        public ElGamalParameter(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            if(seq == 2)
            {
                    this.p = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq);
                this.g = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq);
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Wrong number of elements in sequence", paramName:  "seq");
        }
        public Org.BouncyCastle.Math.BigInteger get_P()
        {
            if(this.p != null)
            {
                    return this.p.PositiveValue;
            }
            
            return this.p.PositiveValue;
        }
        public Org.BouncyCastle.Math.BigInteger get_G()
        {
            if(this.g != null)
            {
                    return this.g.PositiveValue;
            }
            
            return this.g.PositiveValue;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.p != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.p == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.p;
            val_1[1] = this.g;
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_1);
        }
    
    }

}
