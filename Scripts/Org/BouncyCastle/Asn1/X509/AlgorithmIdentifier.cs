using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class AlgorithmIdentifier : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm;
        private readonly Org.BouncyCastle.Asn1.Asn1Encodable parameters;
        
        // Properties
        public virtual Org.BouncyCastle.Asn1.DerObjectIdentifier Algorithm { get; }
        public virtual Org.BouncyCastle.Asn1.DerObjectIdentifier ObjectID { get; }
        public virtual Org.BouncyCastle.Asn1.Asn1Encodable Parameters { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetInstance(object obj)
        {
            object val_3 = obj;
            if(val_3 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)val_3;
            }
            
            Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier val_2 = null;
            val_3 = val_2;
            val_2 = new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_3 = obj));
            return (Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)val_3;
        }
        public AlgorithmIdentifier(Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm)
        {
            this.algorithm = algorithm;
        }
        public AlgorithmIdentifier(string algorithm)
        {
            this.algorithm = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  algorithm);
        }
        public AlgorithmIdentifier(Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, Org.BouncyCastle.Asn1.Asn1Encodable parameters)
        {
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            this.algorithm = algorithm;
            this.parameters = val_1;
        }
        internal AlgorithmIdentifier(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            Org.BouncyCastle.Asn1.Asn1Encodable val_4;
            if((seq >= 1) && (seq < 3))
            {
                    this.algorithm = Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(obj:  seq);
                val_4 = 0;
                if(seq >= 2)
            {
                    val_4 = seq;
            }
            
                this.parameters = val_4;
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Bad sequence size: "("Bad sequence size: ") + seq);
        }
        public virtual Org.BouncyCastle.Asn1.DerObjectIdentifier get_Algorithm()
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)this.algorithm;
        }
        public virtual Org.BouncyCastle.Asn1.DerObjectIdentifier get_ObjectID()
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)this.algorithm;
        }
        public virtual Org.BouncyCastle.Asn1.Asn1Encodable get_Parameters()
        {
            return (Org.BouncyCastle.Asn1.Asn1Encodable)this.parameters;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.algorithm != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.algorithm == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.algorithm;
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  val_1);
            if(new Org.BouncyCastle.Asn1.Asn1Encodable[1] != null)
            {
                    if(this.parameters != null)
            {
                goto label_8;
            }
            
            }
            
            label_8:
        }
    
    }

}
