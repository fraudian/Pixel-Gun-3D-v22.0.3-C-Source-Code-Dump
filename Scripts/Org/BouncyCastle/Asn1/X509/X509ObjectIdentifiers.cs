using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public abstract class X509ObjectIdentifiers
    {
        // Fields
        internal const string ID = "2.5.4";
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier CommonName;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier CountryName;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier LocalityName;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier StateOrProvinceName;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Organization;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier OrganizationalUnitName;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier id_at_telephoneNumber;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier id_at_name;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier RipeMD160;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier RipeMD160WithRsaEncryption;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdEARsa;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdPkix;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdPE;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAD;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdADCAIssuers;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdADOcsp;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier OcspAccessMethod;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier CrlAccessMethod;
        
        // Methods
        protected X509ObjectIdentifiers()
        {
        
        }
        private static X509ObjectIdentifiers()
        {
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.CommonName = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.3");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.CountryName = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.6");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.LocalityName = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.7");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.StateOrProvinceName = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.8");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.Organization = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.10");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.OrganizationalUnitName = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.11");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.id_at_telephoneNumber = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.20");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.id_at_name = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.41");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdSha1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.14.3.2.26");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.RipeMD160 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.36.3.2.1");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.RipeMD160WithRsaEncryption = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.36.3.3.1.2");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdEARsa = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.8.1.1");
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_13 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.5.5.7");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdPkix = val_13;
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdPE = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_13 + ".1");
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_17 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_13 + ".48");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdAD = val_17;
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdADCAIssuers = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_17 + ".2");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdADOcsp = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_17 + ".1");
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.OcspAccessMethod = Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdADOcsp;
            Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.CrlAccessMethod = Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdADCAIssuers;
        }
    
    }

}
