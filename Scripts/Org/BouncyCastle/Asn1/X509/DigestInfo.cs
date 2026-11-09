using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class DigestInfo : Asn1Encodable
    {
        // Fields
        private readonly byte[] digest;
        private readonly Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID;
        
        // Properties
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgorithmID { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.DigestInfo GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.DigestInfo.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.DigestInfo GetInstance(object obj)
        {
            object val_8 = obj;
            if(val_8 != null)
            {
                    val_8 = 0;
                new Org.BouncyCastle.Asn1.X509.DigestInfo() = new Org.BouncyCastle.Asn1.X509.DigestInfo(seq:  val_8);
                return (Org.BouncyCastle.Asn1.X509.DigestInfo)new Org.BouncyCastle.Asn1.X509.DigestInfo();
            }
            
            System.ArgumentException val_7 = new System.ArgumentException(message:  "unknown object in factory: "("unknown object in factory: ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_8 = obj)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_8 = obj)), paramName:  "obj");
        }
        public DigestInfo(Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID, byte[] digest)
        {
            this.digest = digest;
            this.algID = algID;
        }
        private DigestInfo(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            if(seq == 2)
            {
                    this.algID = Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(obj:  seq);
                this.digest = Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(obj:  seq);
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Wrong number of elements in sequence", paramName:  "seq");
        }
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier get_AlgorithmID()
        {
            return (Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)this.algID;
        }
        public byte[] GetDigest()
        {
            return (System.Byte[])this.digest;
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
            val_1[1] = new Org.BouncyCastle.Asn1.DerOctetString(str:  this.digest);
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_1);
        }
    
    }

}
