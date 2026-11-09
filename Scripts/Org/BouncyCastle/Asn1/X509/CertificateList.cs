using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class CertificateList : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.X509.TbsCertificateList tbsCertList;
        private readonly Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgID;
        private readonly Org.BouncyCastle.Asn1.DerBitString sig;
        
        // Properties
        public Org.BouncyCastle.Asn1.X509.TbsCertificateList TbsCertList { get; }
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SignatureAlgorithm { get; }
        public Org.BouncyCastle.Asn1.DerBitString Signature { get; }
        public int Version { get; }
        public Org.BouncyCastle.Asn1.X509.X509Name Issuer { get; }
        public Org.BouncyCastle.Asn1.X509.Time ThisUpdate { get; }
        public Org.BouncyCastle.Asn1.X509.Time NextUpdate { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.CertificateList GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.CertificateList GetInstance(object obj)
        {
            object val_3 = obj;
            if(val_3 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.CertificateList)val_3;
            }
            
            Org.BouncyCastle.Asn1.X509.CertificateList val_2 = null;
            val_3 = val_2;
            val_2 = new Org.BouncyCastle.Asn1.X509.CertificateList(seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_3 = obj));
            return (Org.BouncyCastle.Asn1.X509.CertificateList)val_3;
        }
        private CertificateList(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            if(seq == 3)
            {
                    this.tbsCertList = Org.BouncyCastle.Asn1.X509.TbsCertificateList.GetInstance(obj:  seq);
                this.sigAlgID = Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(obj:  seq);
                this.sig = Org.BouncyCastle.Asn1.DerBitString.GetInstance(obj:  seq);
                return;
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "sequence wrong size for CertificateList", paramName:  "seq");
        }
        public Org.BouncyCastle.Asn1.X509.TbsCertificateList get_TbsCertList()
        {
            return (Org.BouncyCastle.Asn1.X509.TbsCertificateList)this.tbsCertList;
        }
        public Org.BouncyCastle.Asn1.X509.CrlEntry[] GetRevokedCertificates()
        {
            if(this.tbsCertList != null)
            {
                    return this.tbsCertList.GetRevokedCertificates();
            }
            
            return this.tbsCertList.GetRevokedCertificates();
        }
        public System.Collections.IEnumerable GetRevokedCertificateEnumeration()
        {
            if(this.tbsCertList != null)
            {
                    return this.tbsCertList.GetRevokedCertificateEnumeration();
            }
            
            return this.tbsCertList.GetRevokedCertificateEnumeration();
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
        public int get_Version()
        {
            if(this.tbsCertList != null)
            {
                    return this.tbsCertList.Version;
            }
            
            return this.tbsCertList.Version;
        }
        public Org.BouncyCastle.Asn1.X509.X509Name get_Issuer()
        {
            if(this.tbsCertList != null)
            {
                    return (Org.BouncyCastle.Asn1.X509.X509Name)this.tbsCertList.issuer;
            }
            
            return (Org.BouncyCastle.Asn1.X509.X509Name)this.tbsCertList.issuer;
        }
        public Org.BouncyCastle.Asn1.X509.Time get_ThisUpdate()
        {
            if(this.tbsCertList != null)
            {
                    return (Org.BouncyCastle.Asn1.X509.Time)this.tbsCertList.thisUpdate;
            }
            
            return (Org.BouncyCastle.Asn1.X509.Time)this.tbsCertList.thisUpdate;
        }
        public Org.BouncyCastle.Asn1.X509.Time get_NextUpdate()
        {
            if(this.tbsCertList != null)
            {
                    return (Org.BouncyCastle.Asn1.X509.Time)this.tbsCertList.nextUpdate;
            }
            
            return (Org.BouncyCastle.Asn1.X509.Time)this.tbsCertList.nextUpdate;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[3];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.tbsCertList != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.tbsCertList == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.tbsCertList;
            val_1[1] = this.sigAlgID;
            val_1[2] = this.sig;
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_1);
        }
    
    }

}
