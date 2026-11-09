using UnityEngine;

namespace Org.BouncyCastle.Asn1.Pkcs
{
    public class DHParameter : Asn1Encodable
    {
        // Fields
        internal Org.BouncyCastle.Asn1.DerInteger p;
        internal Org.BouncyCastle.Asn1.DerInteger g;
        internal Org.BouncyCastle.Asn1.DerInteger l;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger P { get; }
        public Org.BouncyCastle.Math.BigInteger G { get; }
        public Org.BouncyCastle.Math.BigInteger L { get; }
        
        // Methods
        public DHParameter(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger g, int l)
        {
            Org.BouncyCastle.Math.BigInteger val_4 = g;
            this.p = new Org.BouncyCastle.Asn1.DerInteger(value:  p);
            this.g = new Org.BouncyCastle.Asn1.DerInteger(value:  val_4 = g);
            if(l == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Asn1.DerInteger val_3 = null;
            val_4 = val_3;
            val_3 = new Org.BouncyCastle.Asn1.DerInteger(value:  l);
            this.l = val_4;
        }
        public DHParameter(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            Org.BouncyCastle.Asn1.DerInteger val_13;
            Org.BouncyCastle.Asn1.DerInteger val_16;
            Org.BouncyCastle.Asn1.DerInteger val_19;
            var val_17 = 0;
            val_17 = val_17 + 1;
            bool val_2 = seq.MoveNext();
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_13 = seq;
            if(val_13.Current != null)
            {
                    val_13 = 0;
            }
            
            this.p = val_13;
            var val_19 = 0;
            val_19 = val_19 + 1;
            bool val_8 = seq.MoveNext();
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_16 = seq;
            if(val_16.Current != null)
            {
                    val_16 = 0;
            }
            
            this.g = val_16;
            var val_21 = 0;
            val_21 = val_21 + 1;
            if(seq.MoveNext() == false)
            {
                    return;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_19 = seq;
            if(val_19.Current != null)
            {
                    val_19 = 0;
            }
            
            this.l = val_19;
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
        public Org.BouncyCastle.Math.BigInteger get_L()
        {
            if(this.l == null)
            {
                    return (Org.BouncyCastle.Math.BigInteger)this.l;
            }
            
            return this.l.PositiveValue;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[2];
            val_1[0] = this.p;
            val_1[1] = this.g;
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  val_1);
            if(this.l == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_3 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_3[0] = this.l;
            val_2.Add(objs:  val_3);
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
        }
    
    }

}
