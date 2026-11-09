using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class X509CertificateStructure : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.X509.TbsCertificateStructure tbsCert;
        private readonly Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgID;
        private readonly Org.BouncyCastle.Asn1.DerBitString sig;
        
        // Properties
        public Org.BouncyCastle.Asn1.X509.TbsCertificateStructure TbsCertificate { get; }
        public int Version { get; }
        public Org.BouncyCastle.Asn1.DerInteger SerialNumber { get; }
        public Org.BouncyCastle.Asn1.X509.X509Name Issuer { get; }
        public Org.BouncyCastle.Asn1.X509.Time StartDate { get; }
        public Org.BouncyCastle.Asn1.X509.Time EndDate { get; }
        public Org.BouncyCastle.Asn1.X509.X509Name Subject { get; }
        public Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo SubjectPublicKeyInfo { get; }
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SignatureAlgorithm { get; }
        public Org.BouncyCastle.Asn1.DerBitString Signature { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.X509CertificateStructure GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.X509CertificateStructure GetInstance(object obj)
        {
            object val_3 = obj;
            if(val_3 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.X509CertificateStructure)val_3;
            }
            
            Org.BouncyCastle.Asn1.X509.X509CertificateStructure val_2 = null;
            val_3 = val_2;
            val_2 = new Org.BouncyCastle.Asn1.X509.X509CertificateStructure(seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_3 = obj));
            return (Org.BouncyCastle.Asn1.X509.X509CertificateStructure)val_3;
        }
        public X509CertificateStructure(Org.BouncyCastle.Asn1.X509.TbsCertificateStructure tbsCert, Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgID, Org.BouncyCastle.Asn1.DerBitString sig)
        {
            string val_4;
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            if(tbsCert == null)
            {
                goto label_1;
            }
            
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(sig == null)
            {
                goto label_3;
            }
            
            this.tbsCert = tbsCert;
            this.sigAlgID = val_1;
            this.sig = sig;
            return;
            label_1:
            val_4 = "tbsCert";
            goto label_5;
            label_2:
            val_4 = "sigAlgID";
            goto label_5;
            label_3:
            val_4 = "sig";
            label_5:
            null = new System.ArgumentNullException(paramName:  val_4);
        }
        private X509CertificateStructure(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            if(seq == 3)
            {
                    this.tbsCert = Org.BouncyCastle.Asn1.X509.TbsCertificateStructure.GetInstance(obj:  seq);
                this.sigAlgID = Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(obj:  seq);
                this.sig = Org.BouncyCastle.Asn1.DerBitString.GetInstance(obj:  seq);
                return;
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "sequence wrong size for a certificate", paramName:  "seq");
        }
        public Org.BouncyCastle.Asn1.X509.TbsCertificateStructure get_TbsCertificate()
        {
            return (Org.BouncyCastle.Asn1.X509.TbsCertificateStructure)this.tbsCert;
        }
        public int get_Version()
        {
            if(this.tbsCert != null)
            {
                    return this.tbsCert.Version;
            }
            
            return this.tbsCert.Version;
        }
        public Org.BouncyCastle.Asn1.DerInteger get_SerialNumber()
        {
            if(this.tbsCert != null)
            {
                    return (Org.BouncyCastle.Asn1.DerInteger)this.tbsCert.serialNumber;
            }
            
            return (Org.BouncyCastle.Asn1.DerInteger)this.tbsCert.serialNumber;
        }
        public Org.BouncyCastle.Asn1.X509.X509Name get_Issuer()
        {
            if(this.tbsCert != null)
            {
                    return (Org.BouncyCastle.Asn1.X509.X509Name)this.tbsCert.issuer;
            }
            
            return (Org.BouncyCastle.Asn1.X509.X509Name)this.tbsCert.issuer;
        }
        public Org.BouncyCastle.Asn1.X509.Time get_StartDate()
        {
            if(this.tbsCert != null)
            {
                    return (Org.BouncyCastle.Asn1.X509.Time)this.tbsCert.startDate;
            }
            
            return (Org.BouncyCastle.Asn1.X509.Time)this.tbsCert.startDate;
        }
        public Org.BouncyCastle.Asn1.X509.Time get_EndDate()
        {
            if(this.tbsCert != null)
            {
                    return (Org.BouncyCastle.Asn1.X509.Time)this.tbsCert.endDate;
            }
            
            return (Org.BouncyCastle.Asn1.X509.Time)this.tbsCert.endDate;
        }
        public Org.BouncyCastle.Asn1.X509.X509Name get_Subject()
        {
            if(this.tbsCert != null)
            {
                    return (Org.BouncyCastle.Asn1.X509.X509Name)this.tbsCert.subject;
            }
            
            return (Org.BouncyCastle.Asn1.X509.X509Name)this.tbsCert.subject;
        }
        public Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo get_SubjectPublicKeyInfo()
        {
            if(this.tbsCert != null)
            {
                    return (Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo)this.tbsCert.subjectPublicKeyInfo;
            }
            
            return (Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo)this.tbsCert.subjectPublicKeyInfo;
        }
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier get_SignatureAlgorithm()
        {
            return (Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)this.sigAlgID;
        }
        public Org.BouncyCastle.Asn1.DerBitString get_Signature()
        {
            return (Org.BouncyCastle.Asn1.DerBitString)this.sig;
        }
        public byte[] GetSignatureOctets()
        {
            if(this.sig == null)
            {
                
            }
        
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[3];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.tbsCert != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.tbsCert == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.tbsCert;
            val_1[1] = this.sigAlgID;
            val_1[2] = this.sig;
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_1);
        }
    
    }

}
