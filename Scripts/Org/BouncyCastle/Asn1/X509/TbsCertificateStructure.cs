using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class TbsCertificateStructure : Asn1Encodable
    {
        // Fields
        internal Org.BouncyCastle.Asn1.Asn1Sequence seq;
        internal Org.BouncyCastle.Asn1.DerInteger version;
        internal Org.BouncyCastle.Asn1.DerInteger serialNumber;
        internal Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature;
        internal Org.BouncyCastle.Asn1.X509.X509Name issuer;
        internal Org.BouncyCastle.Asn1.X509.Time startDate;
        internal Org.BouncyCastle.Asn1.X509.Time endDate;
        internal Org.BouncyCastle.Asn1.X509.X509Name subject;
        internal Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo subjectPublicKeyInfo;
        internal Org.BouncyCastle.Asn1.DerBitString issuerUniqueID;
        internal Org.BouncyCastle.Asn1.DerBitString subjectUniqueID;
        internal Org.BouncyCastle.Asn1.X509.X509Extensions extensions;
        
        // Properties
        public int Version { get; }
        public Org.BouncyCastle.Asn1.DerInteger VersionNumber { get; }
        public Org.BouncyCastle.Asn1.DerInteger SerialNumber { get; }
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Signature { get; }
        public Org.BouncyCastle.Asn1.X509.X509Name Issuer { get; }
        public Org.BouncyCastle.Asn1.X509.Time StartDate { get; }
        public Org.BouncyCastle.Asn1.X509.Time EndDate { get; }
        public Org.BouncyCastle.Asn1.X509.X509Name Subject { get; }
        public Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo SubjectPublicKeyInfo { get; }
        public Org.BouncyCastle.Asn1.DerBitString IssuerUniqueID { get; }
        public Org.BouncyCastle.Asn1.DerBitString SubjectUniqueID { get; }
        public Org.BouncyCastle.Asn1.X509.X509Extensions Extensions { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.TbsCertificateStructure GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.TbsCertificateStructure.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.TbsCertificateStructure GetInstance(object obj)
        {
            object val_3 = obj;
            if(val_3 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.TbsCertificateStructure)val_3;
            }
            
            Org.BouncyCastle.Asn1.X509.TbsCertificateStructure val_2 = null;
            val_3 = val_2;
            val_2 = new Org.BouncyCastle.Asn1.X509.TbsCertificateStructure(seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_3 = obj));
            return (Org.BouncyCastle.Asn1.X509.TbsCertificateStructure)val_3;
        }
        internal TbsCertificateStructure(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            var val_20;
            var val_21;
            Org.BouncyCastle.Asn1.Asn1TaggedObject val_22;
            this.seq = seq;
            var val_26 = 0;
            this.version = new Org.BouncyCastle.Asn1.DerInteger(value:  0);
            var val_2 = val_26 + 1;
            this.serialNumber = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq);
            var val_4 = val_26 + 2;
            this.signature = Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(obj:  seq);
            var val_6 = val_26 + 3;
            this.issuer = Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(obj:  seq);
            var val_8 = val_26 + 4;
            if(seq != null)
            {
                    val_20 = 0;
            }
            
            this.startDate = Org.BouncyCastle.Asn1.X509.Time.GetInstance(obj:  0);
            this.endDate = Org.BouncyCastle.Asn1.X509.Time.GetInstance(obj:  0);
            var val_13 = val_26 + 5;
            this.subject = Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(obj:  seq);
            this.subjectPublicKeyInfo = Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo.GetInstance(obj:  seq);
            val_21 = seq;
            Org.BouncyCastle.Asn1.Asn1Sequence val_17 = val_21 - (val_26 + 6);
            val_17 = val_17 - 1;
            if(val_17 < 1)
            {
                    return;
            }
            
            val_26 = (-7) - val_26;
            label_26:
            val_21 = val_21 - 1;
            val_22 = seq;
            val_22 = 0;
            int val_19 = val_22.TagNo;
            if(val_19 == 3)
            {
                goto label_15;
            }
            
            if(val_19 == 2)
            {
                goto label_16;
            }
            
            if(val_19 != 1)
            {
                goto label_23;
            }
            
            this.issuerUniqueID = Org.BouncyCastle.Asn1.DerBitString.GetInstance(obj:  val_22, isExplicit:  false);
            goto label_23;
            label_16:
            this.subjectUniqueID = Org.BouncyCastle.Asn1.DerBitString.GetInstance(obj:  val_22, isExplicit:  false);
            goto label_23;
            label_15:
            this.extensions = Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(obj:  val_22);
            label_23:
            if((val_26 + val_21) >= 1)
            {
                goto label_26;
            }
        
        }
        public int get_Version()
        {
            int val_2 = this.version.Value.IntValue;
            val_2 = val_2 + 1;
            return (int)val_2;
        }
        public Org.BouncyCastle.Asn1.DerInteger get_VersionNumber()
        {
            return (Org.BouncyCastle.Asn1.DerInteger)this.version;
        }
        public Org.BouncyCastle.Asn1.DerInteger get_SerialNumber()
        {
            return (Org.BouncyCastle.Asn1.DerInteger)this.serialNumber;
        }
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier get_Signature()
        {
            return (Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)this.signature;
        }
        public Org.BouncyCastle.Asn1.X509.X509Name get_Issuer()
        {
            return (Org.BouncyCastle.Asn1.X509.X509Name)this.issuer;
        }
        public Org.BouncyCastle.Asn1.X509.Time get_StartDate()
        {
            return (Org.BouncyCastle.Asn1.X509.Time)this.startDate;
        }
        public Org.BouncyCastle.Asn1.X509.Time get_EndDate()
        {
            return (Org.BouncyCastle.Asn1.X509.Time)this.endDate;
        }
        public Org.BouncyCastle.Asn1.X509.X509Name get_Subject()
        {
            return (Org.BouncyCastle.Asn1.X509.X509Name)this.subject;
        }
        public Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo get_SubjectPublicKeyInfo()
        {
            return (Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo)this.subjectPublicKeyInfo;
        }
        public Org.BouncyCastle.Asn1.DerBitString get_IssuerUniqueID()
        {
            return (Org.BouncyCastle.Asn1.DerBitString)this.issuerUniqueID;
        }
        public Org.BouncyCastle.Asn1.DerBitString get_SubjectUniqueID()
        {
            return (Org.BouncyCastle.Asn1.DerBitString)this.subjectUniqueID;
        }
        public Org.BouncyCastle.Asn1.X509.X509Extensions get_Extensions()
        {
            return (Org.BouncyCastle.Asn1.X509.X509Extensions)this.extensions;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this.seq;
        }
    
    }

}
