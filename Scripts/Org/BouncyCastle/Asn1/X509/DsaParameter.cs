using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class DsaParameter : Asn1Encodable
    {
        // Fields
        internal readonly Org.BouncyCastle.Asn1.DerInteger p;
        internal readonly Org.BouncyCastle.Asn1.DerInteger q;
        internal readonly Org.BouncyCastle.Asn1.DerInteger g;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger P { get; }
        public Org.BouncyCastle.Math.BigInteger Q { get; }
        public Org.BouncyCastle.Math.BigInteger G { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.DsaParameter GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.DsaParameter.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.DsaParameter GetInstance(object obj)
        {
            object val_8;
            Org.BouncyCastle.Asn1.Asn1Sequence val_9;
            var val_10;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.DsaParameter)val_10;
            }
            
            val_9 = 0;
            new Org.BouncyCastle.Asn1.X509.DsaParameter() = new Org.BouncyCastle.Asn1.X509.DsaParameter(seq:  val_9);
            val_10 = new Org.BouncyCastle.Asn1.X509.DsaParameter();
            return (Org.BouncyCastle.Asn1.X509.DsaParameter)val_10;
        }
        public DsaParameter(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Math.BigInteger g)
        {
            this.p = new Org.BouncyCastle.Asn1.DerInteger(value:  p);
            this.q = new Org.BouncyCastle.Asn1.DerInteger(value:  q);
            this.g = new Org.BouncyCastle.Asn1.DerInteger(value:  g);
        }
        private DsaParameter(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            if(seq == 3)
            {
                    this.p = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq);
                this.q = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq);
                this.g = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq);
                return;
            }
            
            System.ArgumentException val_5 = new System.ArgumentException(message:  "Bad sequence size: "("Bad sequence size: ") + seq, paramName:  "seq");
        }
        public Org.BouncyCastle.Math.BigInteger get_P()
        {
            if(this.p != null)
            {
                    return this.p.PositiveValue;
            }
            
            return this.p.PositiveValue;
        }
        public Org.BouncyCastle.Math.BigInteger get_Q()
        {
            if(this.q != null)
            {
                    return this.q.PositiveValue;
            }
            
            return this.q.PositiveValue;
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
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[3];
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
            val_1[1] = this.q;
            val_1[2] = this.g;
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_1);
        }
    
    }

}
