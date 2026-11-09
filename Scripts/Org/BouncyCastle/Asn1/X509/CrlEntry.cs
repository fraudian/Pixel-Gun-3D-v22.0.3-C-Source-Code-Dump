using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class CrlEntry : Asn1Encodable
    {
        // Fields
        internal Org.BouncyCastle.Asn1.Asn1Sequence seq;
        internal Org.BouncyCastle.Asn1.DerInteger userCertificate;
        internal Org.BouncyCastle.Asn1.X509.Time revocationDate;
        internal Org.BouncyCastle.Asn1.X509.X509Extensions crlEntryExtensions;
        
        // Properties
        public Org.BouncyCastle.Asn1.DerInteger UserCertificate { get; }
        public Org.BouncyCastle.Asn1.X509.Time RevocationDate { get; }
        public Org.BouncyCastle.Asn1.X509.X509Extensions Extensions { get; }
        
        // Methods
        public CrlEntry(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            if((seq >= 2) && (seq < 4))
            {
                    this.seq = seq;
                this.userCertificate = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq);
                this.revocationDate = Org.BouncyCastle.Asn1.X509.Time.GetInstance(obj:  seq);
                return;
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "Bad sequence size: "("Bad sequence size: ") + seq);
        }
        public Org.BouncyCastle.Asn1.DerInteger get_UserCertificate()
        {
            return (Org.BouncyCastle.Asn1.DerInteger)this.userCertificate;
        }
        public Org.BouncyCastle.Asn1.X509.Time get_RevocationDate()
        {
            return (Org.BouncyCastle.Asn1.X509.Time)this.revocationDate;
        }
        public Org.BouncyCastle.Asn1.X509.X509Extensions get_Extensions()
        {
            Org.BouncyCastle.Asn1.X509.X509Extensions val_2 = this.crlEntryExtensions;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            if(this.seq == 3)
            {
                    this.crlEntryExtensions = Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(obj:  this.seq);
                return val_2;
            }
            
            val_2 = this.crlEntryExtensions;
            return val_2;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this.seq;
        }
    
    }

}
