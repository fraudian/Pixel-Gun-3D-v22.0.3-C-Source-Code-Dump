using UnityEngine;

namespace Org.BouncyCastle.Asn1.Nist
{
    public sealed class NistObjectIdentifiers
    {
        // Fields
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier NistAlgorithm;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier HashAlgs;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha256;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha384;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha512;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha224;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha512_224;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha512_256;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha3_224;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha3_256;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha3_384;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha3_512;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdShake128;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdShake256;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Aes;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes128Ecb;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes128Cbc;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes128Ofb;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes128Cfb;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes128Wrap;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes128Gcm;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes128Ccm;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes192Ecb;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes192Cbc;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes192Ofb;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes192Cfb;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes192Wrap;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes192Gcm;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes192Ccm;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes256Ecb;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes256Cbc;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes256Ofb;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes256Cfb;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes256Wrap;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes256Gcm;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes256Ccm;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdDsaWithSha2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DsaWithSha224;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DsaWithSha256;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DsaWithSha384;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DsaWithSha512;
        
        // Methods
        private NistObjectIdentifiers()
        {
        
        }
        private static NistObjectIdentifiers()
        {
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.16.840.1.101.3.4");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.NistAlgorithm = val_1;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.NistAlgorithm;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_224 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_256 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_384 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_512 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdShake128 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdShake256 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_3 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".1");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes = val_3;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Ecb = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".1");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cbc = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".2");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Ofb = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".3");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cfb = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".4");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Wrap = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".5");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Gcm = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".6");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Ccm = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".7");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Ecb = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".21");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cbc = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".22");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Ofb = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".23");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cfb = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".24");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Wrap = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".25");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Gcm = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".26");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Ccm = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".27");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Ecb = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".41");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cbc = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".42");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Ofb = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".43");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cfb = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".44");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Wrap = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".45");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Gcm = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".46");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Ccm = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_3 + ".47");
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_47 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".3");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2 = val_47;
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_47 + ".1");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_47 + ".2");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_47 + ".3");
            Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_47 + ".4");
        }
    
    }

}
