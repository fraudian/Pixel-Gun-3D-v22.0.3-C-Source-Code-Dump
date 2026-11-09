using UnityEngine;

namespace Org.BouncyCastle.Asn1.X9
{
    public class X9FieldID : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.DerObjectIdentifier id;
        private readonly Org.BouncyCastle.Asn1.Asn1Object parameters;
        
        // Properties
        public Org.BouncyCastle.Asn1.DerObjectIdentifier Identifier { get; }
        public Org.BouncyCastle.Asn1.Asn1Object Parameters { get; }
        
        // Methods
        public X9FieldID(Org.BouncyCastle.Math.BigInteger primeP)
        {
            null = null;
            this.id = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeField;
            this.parameters = new Org.BouncyCastle.Asn1.DerInteger(value:  primeP);
        }
        public X9FieldID(int m, int k1)
        {
        
        }
        public X9FieldID(int m, int k1, int k2, int k3)
        {
            var val_14;
            Org.BouncyCastle.Asn1.Asn1Encodable val_15;
            var val_16;
            Org.BouncyCastle.Asn1.Asn1Encodable val_17;
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_18;
            var val_19;
            val_14 = null;
            val_14 = null;
            this.id = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CharacteristicTwoField;
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            Org.BouncyCastle.Asn1.DerInteger val_2 = null;
            val_15 = val_2;
            val_2 = new Org.BouncyCastle.Asn1.DerInteger(value:  m);
            val_1[0] = val_15;
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_3 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  val_1);
            if(k2 == 0)
            {
                goto label_7;
            }
            
            if((k2 <= k1) || (k3 <= k2))
            {
                goto label_31;
            }
            
            val_16 = null;
            val_17 = new Org.BouncyCastle.Asn1.Asn1Encodable[2];
            val_16 = null;
            val_17[0] = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PPBasis;
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_5 = new Org.BouncyCastle.Asn1.Asn1Encodable[3];
            val_15 = val_5;
            val_15[0] = new Org.BouncyCastle.Asn1.DerInteger(value:  k1);
            val_15[1] = new Org.BouncyCastle.Asn1.DerInteger(value:  k2);
            val_15[2] = new Org.BouncyCastle.Asn1.DerInteger(value:  k3);
            val_17[1] = new Org.BouncyCastle.Asn1.DerSequence(v:  val_5);
            val_18 = val_17;
            goto label_30;
            label_7:
            if(k3 != 0)
            {
                goto label_31;
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_10 = new Org.BouncyCastle.Asn1.Asn1Encodable[2];
            val_19 = null;
            val_19 = null;
            val_10[0] = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.TPBasis;
            Org.BouncyCastle.Asn1.DerInteger val_11 = null;
            val_17 = val_11;
            val_11 = new Org.BouncyCastle.Asn1.DerInteger(value:  k1);
            val_10[1] = val_17;
            val_18 = val_10;
            label_30:
            val_3.Add(objs:  val_10);
            this.parameters = new Org.BouncyCastle.Asn1.DerSequence(v:  val_3);
            return;
            label_31:
            System.ArgumentException val_13 = new System.ArgumentException(message:  "inconsistent k values");
        }
        private X9FieldID(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            this.id = Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(obj:  seq);
            this.parameters = seq.ToAsn1Object();
        }
        public static Org.BouncyCastle.Asn1.X9.X9FieldID GetInstance(object obj)
        {
            object val_3 = obj;
            if(val_3 == null)
            {
                    return (Org.BouncyCastle.Asn1.X9.X9FieldID)val_3;
            }
            
            Org.BouncyCastle.Asn1.X9.X9FieldID val_2 = null;
            val_3 = val_2;
            val_2 = new Org.BouncyCastle.Asn1.X9.X9FieldID(seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_3 = obj));
            return (Org.BouncyCastle.Asn1.X9.X9FieldID)val_3;
        }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier get_Identifier()
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)this.id;
        }
        public Org.BouncyCastle.Asn1.Asn1Object get_Parameters()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this.parameters;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.id != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.id == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.id;
            val_1[1] = this.parameters;
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_1);
        }
    
    }

}
