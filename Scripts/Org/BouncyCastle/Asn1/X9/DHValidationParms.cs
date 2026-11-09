using UnityEngine;

namespace Org.BouncyCastle.Asn1.X9
{
    public class DHValidationParms : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.DerBitString seed;
        private readonly Org.BouncyCastle.Asn1.DerInteger pgenCounter;
        
        // Properties
        public Org.BouncyCastle.Asn1.DerBitString Seed { get; }
        public Org.BouncyCastle.Asn1.DerInteger PgenCounter { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X9.DHValidationParms GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            return Org.BouncyCastle.Asn1.X9.DHValidationParms.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  isExplicit));
        }
        public static Org.BouncyCastle.Asn1.X9.DHValidationParms GetInstance(object obj)
        {
            object val_9;
            Org.BouncyCastle.Asn1.Asn1Sequence val_10;
            var val_11;
            val_9 = obj;
            if(val_9 == null)
            {
                    return (Org.BouncyCastle.Asn1.X9.DHValidationParms)val_11;
            }
            
            val_10 = 0;
            new Org.BouncyCastle.Asn1.X9.DHValidationParms() = new Org.BouncyCastle.Asn1.X9.DHValidationParms(seq:  val_10);
            val_11 = new Org.BouncyCastle.Asn1.X9.DHValidationParms();
            return (Org.BouncyCastle.Asn1.X9.DHValidationParms)val_11;
        }
        public DHValidationParms(Org.BouncyCastle.Asn1.DerBitString seed, Org.BouncyCastle.Asn1.DerInteger pgenCounter)
        {
            string val_4;
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            if(seed == null)
            {
                goto label_1;
            }
            
            if(val_1 == null)
            {
                goto label_2;
            }
            
            this.seed = seed;
            this.pgenCounter = val_1;
            return;
            label_1:
            val_4 = "seed";
            goto label_3;
            label_2:
            val_4 = "pgenCounter";
            label_3:
            null = new System.ArgumentNullException(paramName:  val_4);
        }
        private DHValidationParms(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            if(seq == 2)
            {
                    this.seed = Org.BouncyCastle.Asn1.DerBitString.GetInstance(obj:  seq);
                this.pgenCounter = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq);
                return;
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "Bad sequence size: "("Bad sequence size: ") + seq, paramName:  "seq");
        }
        public Org.BouncyCastle.Asn1.DerBitString get_Seed()
        {
            return (Org.BouncyCastle.Asn1.DerBitString)this.seed;
        }
        public Org.BouncyCastle.Asn1.DerInteger get_PgenCounter()
        {
            return (Org.BouncyCastle.Asn1.DerInteger)this.pgenCounter;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.seed != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.seed == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.seed;
            val_1[1] = this.pgenCounter;
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_1);
        }
    
    }

}
