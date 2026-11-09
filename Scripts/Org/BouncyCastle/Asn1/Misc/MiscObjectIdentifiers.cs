using UnityEngine;

namespace Org.BouncyCastle.Asn1.Misc
{
    public abstract class MiscObjectIdentifiers
    {
        // Fields
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Netscape;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeCertType;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeBaseUrl;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeRevocationUrl;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeCARevocationUrl;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeRenewalUrl;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeCAPolicyUrl;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeSslServerName;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeCertComment;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Verisign;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignCzagExtension;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignPrivate_6_9;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignOnSiteJurisdictionHash;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignBitString_6_13;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignDnbDunsNumber;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignIssStrongCrypto;
        public static readonly string Novell;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier NovellSecurityAttribs;
        public static readonly string Entrust;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier EntrustVersionExtension;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier as_sys_sec_alg_ideaCBC;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm_blowfish_ECB;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm_blowfish_CBC;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm_blowfish_CFB;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm_blowfish_OFB;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier blake2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2b160;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2b256;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2b384;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2b512;
        
        // Methods
        protected MiscObjectIdentifiers()
        {
        
        }
        private static MiscObjectIdentifiers()
        {
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.16.840.1.113730.1");
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.NetscapeCertType = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.NetscapeBaseUrl = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.NetscapeRevocationUrl = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.NetscapeCARevocationUrl = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.NetscapeRenewalUrl = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.NetscapeCAPolicyUrl = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.NetscapeSslServerName = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.NetscapeCertComment = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Verisign = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.16.840.1.113733.1");
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.VerisignCzagExtension = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Verisign;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.VerisignPrivate_6_9 = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Verisign;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.VerisignOnSiteJurisdictionHash = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Verisign;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.VerisignBitString_6_13 = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Verisign;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.VerisignDnbDunsNumber = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Verisign;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.VerisignIssStrongCrypto = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Verisign;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Novell = "2.16.840.1.113719";
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.NovellSecurityAttribs = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Novell + ".1.9.4.1");
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Entrust = "1.2.840.113533.7";
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.EntrustVersionExtension = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Entrust + ".65.0");
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.as_sys_sec_alg_ideaCBC = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.4.1.188.7.1.1.2");
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.4.1.3029");
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib_algorithm = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib_algorithm_blowfish_ECB = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib_algorithm;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib_algorithm_blowfish_CBC = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib_algorithm;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib_algorithm_blowfish_CFB = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib_algorithm;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib_algorithm_blowfish_OFB = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib_algorithm;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.blake2 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.4.1.1722.12.2");
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2b160 = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.blake2;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2b256 = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.blake2;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2b384 = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.blake2;
            Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2b512 = Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.blake2;
        }
    
    }

}
