using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class TbsCertificateList : Asn1Encodable
    {
        // Fields
        internal Org.BouncyCastle.Asn1.Asn1Sequence seq;
        internal Org.BouncyCastle.Asn1.DerInteger version;
        internal Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature;
        internal Org.BouncyCastle.Asn1.X509.X509Name issuer;
        internal Org.BouncyCastle.Asn1.X509.Time thisUpdate;
        internal Org.BouncyCastle.Asn1.X509.Time nextUpdate;
        internal Org.BouncyCastle.Asn1.Asn1Sequence revokedCertificates;
        internal Org.BouncyCastle.Asn1.X509.X509Extensions crlExtensions;
        
        // Properties
        public int Version { get; }
        public Org.BouncyCastle.Asn1.DerInteger VersionNumber { get; }
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Signature { get; }
        public Org.BouncyCastle.Asn1.X509.X509Name Issuer { get; }
        public Org.BouncyCastle.Asn1.X509.Time ThisUpdate { get; }
        public Org.BouncyCastle.Asn1.X509.Time NextUpdate { get; }
        public Org.BouncyCastle.Asn1.X509.X509Extensions Extensions { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.TbsCertificateList GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.TbsCertificateList.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.TbsCertificateList GetInstance(object obj)
        {
            Org.BouncyCastle.Asn1.Asn1Sequence val_8;
            Org.BouncyCastle.Asn1.X509.TbsCertificateList val_9;
            val_8 = obj;
            if(val_8 != null)
            {
                    val_9 = new Org.BouncyCastle.Asn1.X509.TbsCertificateList();
                val_8 = 0;
                val_9 = new Org.BouncyCastle.Asn1.X509.TbsCertificateList(seq:  val_8);
                return (Org.BouncyCastle.Asn1.X509.TbsCertificateList);
            }
            
            val_9 = 0;
            return (Org.BouncyCastle.Asn1.X509.TbsCertificateList);
        }
        internal TbsCertificateList(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            var val_11;
            var val_13;
            var val_16;
            if((seq >= 3) && (seq < 8))
            {
                    this.seq = seq;
                this.version = new Org.BouncyCastle.Asn1.DerInteger(value:  0);
                var val_2 = 0 + 1;
                this.signature = Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(obj:  seq);
                var val_4 = 0 | 2;
                this.issuer = Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(obj:  seq);
                val_11 = val_4 + 1;
                this.thisUpdate = Org.BouncyCastle.Asn1.X509.Time.GetInstance(obj:  seq);
                if(val_11 < seq)
            {
                    val_13 = val_11;
                if(seq != null)
            {
                    val_13 = val_11;
                val_4 = val_4 + 2;
                val_11 = val_4;
                this.nextUpdate = Org.BouncyCastle.Asn1.X509.Time.GetInstance(obj:  seq);
            }
            
            }
            
                if(val_11 < seq)
            {
                    val_16 = val_11;
                val_4 = val_11 + 1;
                val_16 = 0;
                val_11 = val_4;
                this.revokedCertificates = Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  seq);
            }
            
                if(val_11 >= seq)
            {
                    return;
            }
            
                if(seq == null)
            {
                    return;
            }
            
                this.crlExtensions = Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(obj:  seq);
                return;
            }
            
            System.ArgumentException val_12 = new System.ArgumentException(message:  "Bad sequence size: "("Bad sequence size: ") + seq);
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
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier get_Signature()
        {
            return (Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)this.signature;
        }
        public Org.BouncyCastle.Asn1.X509.X509Name get_Issuer()
        {
            return (Org.BouncyCastle.Asn1.X509.X509Name)this.issuer;
        }
        public Org.BouncyCastle.Asn1.X509.Time get_ThisUpdate()
        {
            return (Org.BouncyCastle.Asn1.X509.Time)this.thisUpdate;
        }
        public Org.BouncyCastle.Asn1.X509.Time get_NextUpdate()
        {
            return (Org.BouncyCastle.Asn1.X509.Time)this.nextUpdate;
        }
        public Org.BouncyCastle.Asn1.X509.CrlEntry[] GetRevokedCertificates()
        {
            var val_5;
            var val_6;
            if(this.revokedCertificates == null)
            {
                goto label_1;
            }
            
            val_5 = new Org.BouncyCastle.Asn1.X509.CrlEntry[0];
            val_6 = 0;
            goto label_2;
            label_8:
            val_6 = 1;
            val_5[0] = new Org.BouncyCastle.Asn1.X509.CrlEntry(seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  this.revokedCertificates));
            label_2:
            if(val_6 < val_1.Length)
            {
                goto label_8;
            }
            
            return (Org.BouncyCastle.Asn1.X509.CrlEntry[])val_5;
            label_1:
            val_5 = new Org.BouncyCastle.Asn1.X509.CrlEntry[0];
            return (Org.BouncyCastle.Asn1.X509.CrlEntry[])val_5;
        }
        public System.Collections.IEnumerable GetRevokedCertificateEnumeration()
        {
            System.Collections.IEnumerable val_2;
            var val_3;
            if(this.revokedCertificates != null)
            {
                    TbsCertificateList.RevokedCertificatesEnumeration val_1 = null;
                val_2 = val_1;
                val_1 = new TbsCertificateList.RevokedCertificatesEnumeration();
                .en = this.revokedCertificates;
                return val_2;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = Org.BouncyCastle.Utilities.Collections.EmptyEnumerable.Instance;
            return val_2;
        }
        public Org.BouncyCastle.Asn1.X509.X509Extensions get_Extensions()
        {
            return (Org.BouncyCastle.Asn1.X509.X509Extensions)this.crlExtensions;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this.seq;
        }
    
    }

}
