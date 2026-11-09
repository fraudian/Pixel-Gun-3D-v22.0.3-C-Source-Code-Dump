using UnityEngine;

namespace Org.BouncyCastle.Asn1.Oiw
{
    public abstract class OiwObjectIdentifiers
    {
        // Fields
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier MD4WithRsa;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier MD5WithRsa;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier MD4WithRsaEncryption;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DesEcb;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DesCbc;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DesOfb;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DesCfb;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DesEde;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DsaWithSha1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Sha1WithRsa;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ElGamalAlgorithm;
        
        // Methods
        protected OiwObjectIdentifiers()
        {
        
        }
        private static OiwObjectIdentifiers()
        {
            Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD4WithRsa = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.14.3.2.2");
            Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD5WithRsa = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.14.3.2.3");
            Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD4WithRsaEncryption = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.14.3.2.4");
            Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesEcb = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.14.3.2.6");
            Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesCbc = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.14.3.2.7");
            Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesOfb = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.14.3.2.8");
            Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesCfb = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.14.3.2.9");
            Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesEde = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.14.3.2.17");
            Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.14.3.2.26");
            Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DsaWithSha1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.14.3.2.27");
            Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.Sha1WithRsa = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.14.3.2.29");
            Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.ElGamalAlgorithm = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.14.7.2.1.1");
        }
    
    }

}
