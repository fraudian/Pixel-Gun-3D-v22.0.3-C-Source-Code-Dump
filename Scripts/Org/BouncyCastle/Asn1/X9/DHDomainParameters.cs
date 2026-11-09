using UnityEngine;

namespace Org.BouncyCastle.Asn1.X9
{
    public class DHDomainParameters : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.DerInteger p;
        private readonly Org.BouncyCastle.Asn1.DerInteger g;
        private readonly Org.BouncyCastle.Asn1.DerInteger q;
        private readonly Org.BouncyCastle.Asn1.DerInteger j;
        private readonly Org.BouncyCastle.Asn1.X9.DHValidationParms validationParms;
        
        // Properties
        public Org.BouncyCastle.Asn1.DerInteger P { get; }
        public Org.BouncyCastle.Asn1.DerInteger G { get; }
        public Org.BouncyCastle.Asn1.DerInteger Q { get; }
        public Org.BouncyCastle.Asn1.DerInteger J { get; }
        public Org.BouncyCastle.Asn1.X9.DHValidationParms ValidationParms { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X9.DHDomainParameters GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            return Org.BouncyCastle.Asn1.X9.DHDomainParameters.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  isExplicit));
        }
        public static Org.BouncyCastle.Asn1.X9.DHDomainParameters GetInstance(object obj)
        {
            object val_8;
            Org.BouncyCastle.Asn1.Asn1Sequence val_9;
            var val_10;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.X9.DHDomainParameters)val_10;
            }
            
            val_9 = 0;
            new Org.BouncyCastle.Asn1.X9.DHDomainParameters() = new Org.BouncyCastle.Asn1.X9.DHDomainParameters(seq:  val_9);
            val_10 = new Org.BouncyCastle.Asn1.X9.DHDomainParameters();
            return (Org.BouncyCastle.Asn1.X9.DHDomainParameters)val_10;
        }
        public DHDomainParameters(Org.BouncyCastle.Asn1.DerInteger p, Org.BouncyCastle.Asn1.DerInteger g, Org.BouncyCastle.Asn1.DerInteger q, Org.BouncyCastle.Asn1.DerInteger j, Org.BouncyCastle.Asn1.X9.DHValidationParms validationParms)
        {
            string val_4;
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            if(p == null)
            {
                goto label_1;
            }
            
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(q == null)
            {
                goto label_3;
            }
            
            this.p = p;
            this.g = val_1;
            this.q = q;
            this.j = j;
            this.validationParms = validationParms;
            return;
            label_1:
            val_4 = "p";
            goto label_5;
            label_2:
            val_4 = "g";
            goto label_5;
            label_3:
            val_4 = "q";
            label_5:
            null = new System.ArgumentNullException(paramName:  val_4);
        }
        private DHDomainParameters(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            var val_13;
            if((seq >= 3) && (seq < 6))
            {
                    this.p = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  Org.BouncyCastle.Asn1.X9.DHDomainParameters.GetNext(e:  seq));
                this.g = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  Org.BouncyCastle.Asn1.X9.DHDomainParameters.GetNext(e:  seq));
                val_13 = 0;
                this.q = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  Org.BouncyCastle.Asn1.X9.DHDomainParameters.GetNext(e:  seq));
                Org.BouncyCastle.Asn1.Asn1Encodable val_7 = Org.BouncyCastle.Asn1.X9.DHDomainParameters.GetNext(e:  seq);
                if(val_7 == null)
            {
                    return;
            }
            
                val_13 = 0;
                this.j = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  val_7);
                Org.BouncyCastle.Asn1.Asn1Encodable val_9 = Org.BouncyCastle.Asn1.X9.DHDomainParameters.GetNext(e:  seq);
                if(val_9 == null)
            {
                    return;
            }
            
                this.validationParms = Org.BouncyCastle.Asn1.X9.DHValidationParms.GetInstance(obj:  val_9);
                return;
            }
            
            System.ArgumentException val_12 = new System.ArgumentException(message:  "Bad sequence size: "("Bad sequence size: ") + seq, paramName:  "seq");
        }
        private static Org.BouncyCastle.Asn1.Asn1Encodable GetNext(System.Collections.IEnumerator e)
        {
            var val_7;
            var val_7 = 0;
            val_7 = val_7 + 1;
            if(e.MoveNext() != false)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                val_7 = e;
                if(val_7.Current == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Encodable)val_7;
            }
            
            }
            
            val_7 = 0;
            return (Org.BouncyCastle.Asn1.Asn1Encodable)val_7;
        }
        public Org.BouncyCastle.Asn1.DerInteger get_P()
        {
            return (Org.BouncyCastle.Asn1.DerInteger)this.p;
        }
        public Org.BouncyCastle.Asn1.DerInteger get_G()
        {
            return (Org.BouncyCastle.Asn1.DerInteger)this.g;
        }
        public Org.BouncyCastle.Asn1.DerInteger get_Q()
        {
            return (Org.BouncyCastle.Asn1.DerInteger)this.q;
        }
        public Org.BouncyCastle.Asn1.DerInteger get_J()
        {
            return (Org.BouncyCastle.Asn1.DerInteger)this.j;
        }
        public Org.BouncyCastle.Asn1.X9.DHValidationParms get_ValidationParms()
        {
            return (Org.BouncyCastle.Asn1.X9.DHValidationParms)this.validationParms;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_6;
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[3];
            val_6 = val_1;
            val_6[0] = this.p;
            val_6[1] = this.g;
            val_6[2] = this.q;
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  val_1);
            if(this.j != null)
            {
                    Org.BouncyCastle.Asn1.Asn1Encodable[] val_3 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
                val_6 = val_3;
                val_6[0] = this.j;
                val_2.Add(objs:  val_3);
            }
            
            if(this.validationParms == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_4 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_6 = this.validationParms;
            val_4[0] = val_6;
            val_2.Add(objs:  val_4);
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
        }
    
    }

}
