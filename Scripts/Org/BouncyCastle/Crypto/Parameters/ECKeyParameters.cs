using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public abstract class ECKeyParameters : AsymmetricKeyParameter
    {
        // Fields
        private static readonly string[] algorithms;
        private readonly string algorithm;
        private readonly Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters;
        private readonly Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet;
        
        // Properties
        public string AlgorithmName { get; }
        public Org.BouncyCastle.Crypto.Parameters.ECDomainParameters Parameters { get; }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet { get; }
        
        // Methods
        protected ECKeyParameters(string algorithm, bool isPrivate, Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters)
        {
            string val_5;
            bool val_1 = isPrivate;
            if(algorithm == null)
            {
                goto label_1;
            }
            
            if(parameters == null)
            {
                goto label_2;
            }
            
            this.algorithm = Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.VerifyAlgorithmName(algorithm:  algorithm);
            this.parameters = parameters;
            return;
            label_1:
            val_5 = "algorithm";
            goto label_5;
            label_2:
            val_5 = "parameters";
            label_5:
            null = new System.ArgumentNullException(paramName:  val_5);
        }
        protected ECKeyParameters(string algorithm, bool isPrivate, Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet)
        {
            string val_6;
            bool val_1 = isPrivate;
            if(algorithm == null)
            {
                goto label_1;
            }
            
            if(publicKeyParamSet == null)
            {
                goto label_2;
            }
            
            this.algorithm = Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.VerifyAlgorithmName(algorithm:  algorithm);
            this.parameters = Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.LookupParameters(publicKeyParamSet:  publicKeyParamSet);
            this.publicKeyParamSet = publicKeyParamSet;
            return;
            label_1:
            val_6 = "algorithm";
            goto label_5;
            label_2:
            val_6 = "publicKeyParamSet";
            label_5:
            null = new System.ArgumentNullException(paramName:  val_6);
        }
        public string get_AlgorithmName()
        {
            return (string)this.algorithm;
        }
        public Org.BouncyCastle.Crypto.Parameters.ECDomainParameters get_Parameters()
        {
            return (Org.BouncyCastle.Crypto.Parameters.ECDomainParameters)this.parameters;
        }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier get_PublicKeyParamSet()
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)this.publicKeyParamSet;
        }
        public override bool Equals(object obj)
        {
            var val_1;
            if(this != obj)
            {
                    val_1 = 0;
                return (bool)val_1;
            }
            
            val_1 = 1;
            return (bool)val_1;
        }
        protected bool Equals(Org.BouncyCastle.Crypto.Parameters.ECKeyParameters other)
        {
            if((this.parameters & 1) == 0)
            {
                    return false;
            }
            
            return other.Equals(other:  other);
        }
        public override int GetHashCode()
        {
            int val_1 = this.GetHashCode();
            val_1 = val_1 ^ this.parameters;
            return (int)val_1;
        }
        internal Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters CreateKeyGenerationParameters(Org.BouncyCastle.Security.SecureRandom random)
        {
            var val_3;
            if(this.publicKeyParamSet != null)
            {
                    Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters val_1 = null;
                val_3 = val_1;
                val_1 = new Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters(publicKeyParamSet:  this.publicKeyParamSet, random:  random);
                return (Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters)val_3;
            }
            
            Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters val_2 = null;
            val_3 = val_2;
            val_2 = new Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters(domainParameters:  this.parameters, random:  random);
            return (Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters)val_3;
        }
        internal static string VerifyAlgorithmName(string algorithm)
        {
            var val_5 = null;
            if(((System.Array.IndexOf<System.String>(array:  Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.algorithms, value:  algorithm, startIndex:  0, count:  Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.algorithms.Length)) & 2147483648) == 0)
            {
                    return (string)Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  algorithm);
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "unrecognised algorithm: "("unrecognised algorithm: ") + algorithm, paramName:  "algorithm");
        }
        internal static Org.BouncyCastle.Crypto.Parameters.ECDomainParameters LookupParameters(Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet)
        {
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_11;
            var val_12;
            var val_13;
            val_11 = publicKeyParamSet;
            if(val_11 == null)
            {
                goto label_1;
            }
            
            val_12 = Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.GetByOid(oid:  val_11);
            if(val_12 != null)
            {
                    return (Org.BouncyCastle.Crypto.Parameters.ECDomainParameters)val_12;
            }
            
            Org.BouncyCastle.Asn1.X9.X9ECParameters val_2 = Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator.FindECCurveByOid(oid:  val_11);
            if(val_2 == null)
            {
                goto label_5;
            }
            
            val_11 = val_2.GetSeed();
            Org.BouncyCastle.Crypto.Parameters.ECDomainParameters val_8 = null;
            val_12 = val_8;
            val_8 = new Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve:  val_2.Curve, g:  val_2.G, n:  val_2.N, h:  val_2.H, seed:  val_11);
            return (Org.BouncyCastle.Crypto.Parameters.ECDomainParameters)val_12;
            label_1:
            System.ArgumentNullException val_9 = null;
            val_13 = val_9;
            val_9 = new System.ArgumentNullException(paramName:  "publicKeyParamSet");
            goto label_6;
            label_5:
            System.ArgumentException val_10 = null;
            val_13 = val_10;
            val_10 = new System.ArgumentException(message:  "OID is not a valid public key parameter set", paramName:  "publicKeyParamSet");
            label_6:
        }
        private static ECKeyParameters()
        {
            string[] val_1 = new string[6];
            val_1[0] = "EC";
            val_1[1] = "ECDSA";
            val_1[2] = "ECDH";
            val_1[3] = "ECDHC";
            val_1[4] = "ECGOST3410";
            val_1[5] = "ECMQV";
            Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.algorithms = val_1;
        }
    
    }

}
