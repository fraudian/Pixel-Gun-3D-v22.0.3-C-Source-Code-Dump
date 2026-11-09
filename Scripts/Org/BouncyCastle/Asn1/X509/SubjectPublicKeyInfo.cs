using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class SubjectPublicKeyInfo : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID;
        private readonly Org.BouncyCastle.Asn1.DerBitString keyData;
        
        // Properties
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgorithmID { get; }
        public Org.BouncyCastle.Asn1.DerBitString PublicKeyData { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo GetInstance(object obj)
        {
            object val_3 = obj;
            if(val_3 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo)val_3;
            }
            
            Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo val_2 = null;
            val_3 = val_2;
            val_2 = new Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo(seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_3 = obj));
            return (Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo)val_3;
        }
        public SubjectPublicKeyInfo(Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID, Org.BouncyCastle.Asn1.Asn1Encodable publicKey)
        {
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            this.algID = algID;
            this.keyData = new Org.BouncyCastle.Asn1.DerBitString(obj:  Org.BouncyCastle.Asn1.Asn1Encodable val_1 = publicKey);
        }
        public SubjectPublicKeyInfo(Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID, byte[] publicKey)
        {
            this.algID = algID;
            this.keyData = new Org.BouncyCastle.Asn1.DerBitString(data:  publicKey);
        }
        private SubjectPublicKeyInfo(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            if(seq == 2)
            {
                    this.algID = Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(obj:  seq);
                this.keyData = Org.BouncyCastle.Asn1.DerBitString.GetInstance(obj:  seq);
                return;
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "Bad sequence size: "("Bad sequence size: ") + seq, paramName:  "seq");
        }
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier get_AlgorithmID()
        {
            return (Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)this.algID;
        }
        public Org.BouncyCastle.Asn1.Asn1Object GetPublicKey()
        {
            if(this.keyData != null)
            {
                    return Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(data:  this.keyData);
            }
            
            return Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(data:  this.keyData);
        }
        public Org.BouncyCastle.Asn1.DerBitString get_PublicKeyData()
        {
            return (Org.BouncyCastle.Asn1.DerBitString)this.keyData;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.algID != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.algID == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.algID;
            val_1[1] = this.keyData;
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_1);
        }
    
    }

}
