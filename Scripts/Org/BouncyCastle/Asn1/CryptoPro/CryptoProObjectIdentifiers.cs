using UnityEngine;

namespace Org.BouncyCastle.Asn1.CryptoPro
{
    public abstract class CryptoProObjectIdentifiers
    {
        // Fields
        public const string GostID = "1.2.643.2.2";
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3411;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3411Hmac;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR28147Cbc;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ID_Gost28147_89_CryptoPro_A_ParamSet;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x2001;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3411x94WithGostR3410x94;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3411x94WithGostR3410x2001;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3411x94CryptoProParamSet;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94CryptoProA;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94CryptoProB;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94CryptoProC;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94CryptoProD;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94CryptoProXchA;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94CryptoProXchB;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94CryptoProXchC;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x2001CryptoProA;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x2001CryptoProB;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x2001CryptoProC;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x2001CryptoProXchA;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x2001CryptoProXchB;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostElSgDH3410Default;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GostElSgDH3410x1;
        
        // Methods
        protected CryptoProObjectIdentifiers()
        {
        
        }
        private static CryptoProObjectIdentifiers()
        {
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.9");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411Hmac = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.10");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR28147Cbc = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.21");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.ID_Gost28147_89_CryptoPro_A_ParamSet = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.31.1");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.20");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.19");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.4");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.3");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94CryptoProParamSet = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.30.1");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProA = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.32.2");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProB = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.32.3");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProC = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.32.4");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProD = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.32.5");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProXchA = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.33.1");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProXchB = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.33.2");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProXchC = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.33.3");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProA = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.35.1");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProB = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.35.2");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProC = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.35.3");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProXchA = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.36.0");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProXchB = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.36.1");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostElSgDH3410Default = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.36.0");
            Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostElSgDH3410x1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.643.2.2.36.1");
        }
    
    }

}
