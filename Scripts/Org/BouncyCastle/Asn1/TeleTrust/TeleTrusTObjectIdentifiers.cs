using UnityEngine;

namespace Org.BouncyCastle.Asn1.TeleTrust
{
    public sealed class TeleTrusTObjectIdentifiers
    {
        // Fields
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier TeleTrusTAlgorithm;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier RipeMD160;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier RipeMD128;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier RipeMD256;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier TeleTrusTRsaSignatureAlgorithm;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier RsaSignatureWithRipeMD160;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier RsaSignatureWithRipeMD128;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier RsaSignatureWithRipeMD256;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ECSign;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ECSignWithSha1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ECSignWithRipeMD160;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier EccBrainpool;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier EllipticCurve;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier VersionOne;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP160R1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP160T1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP192R1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP192T1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP224R1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP224T1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP256R1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP256T1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP320R1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP320T1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP384R1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP384T1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP512R1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP512T1;
        
        // Methods
        private TeleTrusTObjectIdentifiers()
        {
        
        }
        private static TeleTrusTObjectIdentifiers()
        {
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.36.3");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.TeleTrusTAlgorithm = val_1;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".2.1");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".2.2");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".2.3");
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_9 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".3.1");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.TeleTrusTRsaSignatureAlgorithm = val_9;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_9 + ".2");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_9 + ".3");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_9 + ".4");
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_17 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".3.2");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.ECSign = val_17;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.ECSignWithSha1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_17 + ".1");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.ECSignWithRipeMD160 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_17 + ".2");
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_23 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".3.2.8");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.EccBrainpool = val_23;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_25 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_23 + ".1");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.EllipticCurve = val_25;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_27 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_25 + ".1");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne = val_27;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP160R1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_27 + ".1");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP160T1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_27 + ".2");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP192R1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_27 + ".3");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP192T1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_27 + ".4");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP224R1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_27 + ".5");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP224T1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_27 + ".6");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP256R1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_27 + ".7");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP256T1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_27 + ".8");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP320R1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_27 + ".9");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP320T1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_27 + ".10");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP384R1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_27 + ".11");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP384T1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_27 + ".12");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP512R1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_27 + ".13");
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP512T1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_27 + ".14");
        }
    
    }

}
