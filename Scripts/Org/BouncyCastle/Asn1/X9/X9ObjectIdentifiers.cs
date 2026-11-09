using UnityEngine;

namespace Org.BouncyCastle.Asn1.X9
{
    public abstract class X9ObjectIdentifiers
    {
        // Fields
        internal const string AnsiX962 = "1.2.840.10045";
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ansi_X9_62;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdFieldType;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier PrimeField;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier CharacteristicTwoField;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GNBasis;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier TPBasis;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier PPBasis;
        public const string IdECSigType = "1.2.840.10045.4";
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier id_ecSigType;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha1;
        public const string IdPublicKeyType = "1.2.840.10045.2";
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier id_publicKeyType;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdECPublicKey;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha224;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha256;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha384;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha512;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier EllipticCurve;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier CTwoCurve;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb163v1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb163v2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb163v3;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb176w1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb191v1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb191v2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb191v3;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Onb191v4;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Onb191v5;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb208w1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb239v1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb239v2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb239v3;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Onb239v4;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Onb239v5;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb272w1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb304w1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb359v1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb368w1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb431r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier PrimeCurve;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Prime192v1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Prime192v2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Prime192v3;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Prime239v1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Prime239v2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Prime239v3;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Prime256v1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdDsa;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IdDsaWithSha1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier X9x63Scheme;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DHSinglePassStdDHSha1KdfScheme;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DHSinglePassCofactorDHSha1KdfScheme;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier MqvSinglePassSha1KdfScheme;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ansi_x9_42;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DHPublicNumber;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier X9x42Schemes;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DHStatic;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DHEphem;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DHOneFlow;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DHHybrid1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DHHybrid2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DHHybridOneFlow;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Mqv2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Mqv1;
        
        // Methods
        protected X9ObjectIdentifiers()
        {
        
        }
        private static X9ObjectIdentifiers()
        {
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdPublicKeyType = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.840.10045");
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdFieldType = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdPublicKeyType;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeField = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdFieldType;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CharacteristicTwoField = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdFieldType;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.GNBasis = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CharacteristicTwoField;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.TPBasis = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CharacteristicTwoField;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PPBasis = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CharacteristicTwoField;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.id_ecSigType = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdPublicKeyType;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.id_ecSigType;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.id_publicKeyType = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdPublicKeyType;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdECPublicKey = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.id_publicKeyType;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha2 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.id_ecSigType;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha2;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha2;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha2;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha2;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.EllipticCurve = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdPublicKeyType;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.EllipticCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb163v1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb163v2 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb163v3 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb176w1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb191v1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb191v2 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb191v3 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Onb191v4 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Onb191v5 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb208w1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb239v1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb239v2 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb239v3 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Onb239v4 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Onb239v5 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb272w1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb304w1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb359v1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb368w1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb431r1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.EllipticCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime192v1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime192v2 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime192v3 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime239v1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime239v2 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime239v3 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime256v1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsa = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.840.10040.4.1");
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.840.10040.4.3");
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x63Scheme = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.133.16.840.63.0");
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHSinglePassStdDHSha1KdfScheme = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x63Scheme;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHSinglePassCofactorDHSha1KdfScheme = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x63Scheme;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.MqvSinglePassSha1KdfScheme = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x63Scheme;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ansi_x9_42 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.840.10046");
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHPublicNumber = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ansi_x9_42;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ansi_x9_42;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHStatic = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHEphem = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHOneFlow = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHHybrid1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHHybrid2 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHHybridOneFlow = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Mqv2 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes;
            Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Mqv1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes;
        }
    
    }

}
