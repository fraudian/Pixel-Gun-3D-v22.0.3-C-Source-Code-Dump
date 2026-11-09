using UnityEngine;

namespace Org.BouncyCastle.Crypto.Generators
{
    public class ECKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
    {
        // Fields
        private readonly string algorithm;
        private Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters;
        private Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet;
        private Org.BouncyCastle.Security.SecureRandom random;
        
        // Methods
        public ECKeyPairGenerator()
        {
        
        }
        public ECKeyPairGenerator(string algorithm)
        {
            if(algorithm != null)
            {
                    this.algorithm = Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.VerifyAlgorithmName(algorithm:  algorithm);
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "algorithm");
        }
        public void Init(Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
        {
            Org.BouncyCastle.Crypto.Parameters.ECDomainParameters val_16;
            var val_17;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            Org.BouncyCastle.Math.EC.ECCurve val_24;
            Org.BouncyCastle.Math.EC.ECPoint val_25;
            Org.BouncyCastle.Math.BigInteger val_26;
            Org.BouncyCastle.Math.BigInteger val_27;
            if(parameters == null)
            {
                goto label_1;
            }
            
            this.publicKeyParamSet = parameters.PublicKeyParamSet;
            val_16 = parameters.DomainParameters;
            goto label_4;
            label_1:
            if(parameters.strength <= 239)
            {
                goto label_5;
            }
            
            if(parameters.strength == 256)
            {
                goto label_6;
            }
            
            if(parameters.strength == 384)
            {
                goto label_7;
            }
            
            if(parameters.strength != 521)
            {
                goto label_14;
            }
            
            val_17 = null;
            val_17 = null;
            val_18 = 1152921505551151320;
            goto label_26;
            label_5:
            if(parameters.strength == 192)
            {
                goto label_12;
            }
            
            if(parameters.strength == 224)
            {
                goto label_13;
            }
            
            if(parameters.strength != 239)
            {
                goto label_14;
            }
            
            val_19 = null;
            val_19 = null;
            val_18 = 1152921505546678608;
            goto label_26;
            label_6:
            val_20 = null;
            val_20 = null;
            val_18 = 1152921505546678632;
            goto label_26;
            label_7:
            val_21 = null;
            val_21 = null;
            val_18 = 1152921505551151312;
            goto label_26;
            label_12:
            val_22 = null;
            val_22 = null;
            val_18 = 1152921505546678584;
            goto label_26;
            label_13:
            val_23 = null;
            val_23 = null;
            val_18 = 1152921505551151304;
            label_26:
            Org.BouncyCastle.Asn1.X9.X9ECParameters val_3 = Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator.FindECCurveByOid(oid:  val_18);
            this.publicKeyParamSet = val_18;
            if(val_3 != null)
            {
                    val_24 = val_3.Curve;
                val_25 = val_3.G;
                val_26 = val_3.N;
                val_27 = val_3.H;
            }
            else
            {
                    val_24 = 0.Curve;
                val_25 = 0.G;
                val_26 = 0.N;
                val_27 = 0.H;
            }
            
            Org.BouncyCastle.Crypto.Parameters.ECDomainParameters val_13 = null;
            val_16 = val_13;
            val_13 = new Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve:  val_24, g:  val_25, n:  val_26, h:  val_27, seed:  val_3.GetSeed());
            label_4:
            this.parameters = val_16;
            this.random = parameters.random;
            if(parameters.random != null)
            {
                    return;
            }
            
            this.random = new Org.BouncyCastle.Security.SecureRandom();
            return;
            label_14:
            Org.BouncyCastle.Security.InvalidParameterException val_15 = new Org.BouncyCastle.Security.InvalidParameterException(message:  "unknown key size.");
        }
        public Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
        {
            var val_16;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_18;
            Org.BouncyCastle.Crypto.AsymmetricKeyParameter val_19;
            string val_20;
            Org.BouncyCastle.Crypto.AsymmetricKeyParameter val_21;
            Org.BouncyCastle.Math.BigInteger val_1 = this.parameters.N;
            do
            {
                Org.BouncyCastle.Math.BigInteger val_5 = new Org.BouncyCastle.Math.BigInteger(sizeInBits:  val_1.BitLength, random:  this.random);
                val_16 = null;
                val_16 = null;
            }
            while(((val_5.CompareTo(value:  Org.BouncyCastle.Math.BigInteger.Two)) & 2147483648) != 0);
            
            if((((val_5.CompareTo(value:  val_1)) & 2147483648) != 0) && ((Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetNafWeight(k:  val_5)) >= (val_1.BitLength >> 2)))
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                Org.BouncyCastle.Math.EC.ECPoint val_11 = this.Multiply(p:  this.parameters.G, k:  val_5);
                val_18 = this.publicKeyParamSet;
                if(val_18 != null)
            {
                    Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters val_12 = null;
                val_19 = val_12;
                val_12 = new Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(algorithm:  this.algorithm, q:  val_11, publicKeyParamSet:  val_18);
                val_20 = this.algorithm;
                Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters val_13 = null;
                val_21 = val_13;
                val_13 = new Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters(algorithm:  val_20, d:  val_5, publicKeyParamSet:  this.publicKeyParamSet);
                return (Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)new Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(publicParameter:  Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters val_14 = null, privateParameter:  Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters val_15 = null);
            }
            
                val_18 = this.parameters;
                val_19 = val_14;
                val_14 = new Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(algorithm:  this.algorithm, q:  val_11, parameters:  val_18);
                val_20 = this.algorithm;
                val_21 = val_15;
                val_15 = new Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters(algorithm:  val_20, d:  val_5, parameters:  this.parameters);
                return (Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)new Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(publicParameter:  val_14, privateParameter:  val_15);
            }
        
        }
        protected virtual Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateBasePointMultiplier()
        {
            return (Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier)new Org.BouncyCastle.Math.EC.Multiplier.FixedPointCombMultiplier();
        }
        internal static Org.BouncyCastle.Asn1.X9.X9ECParameters FindECCurveByOid(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            Org.BouncyCastle.Asn1.X9.X9ECParameters val_1 = Org.BouncyCastle.Crypto.EC.CustomNamedCurves.GetByOid(oid:  oid);
            if(val_1 == null)
            {
                    return Org.BouncyCastle.Asn1.X9.ECNamedCurveTable.GetByOid(oid:  oid);
            }
            
            return val_1;
        }
        internal static Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters GetCorrespondingPublicKey(Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privKey)
        {
            string val_13;
            var val_14;
            Org.BouncyCastle.Crypto.Parameters.ECDomainParameters val_1 = privKey.Parameters;
            Org.BouncyCastle.Math.EC.ECPoint val_5 = new Org.BouncyCastle.Math.EC.Multiplier.FixedPointCombMultiplier().Multiply(p:  val_1.G, k:  privKey.D);
            if(privKey == null)
            {
                goto label_5;
            }
            
            val_13 = privKey.AlgorithmName;
            if(privKey.PublicKeyParamSet != null)
            {
                goto label_6;
            }
            
            goto label_8;
            label_5:
            val_13 = privKey.AlgorithmName;
            if(privKey.PublicKeyParamSet == null)
            {
                goto label_8;
            }
            
            label_6:
            Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters val_11 = null;
            val_14 = val_11;
            val_11 = new Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(algorithm:  val_13, q:  val_5, publicKeyParamSet:  privKey.PublicKeyParamSet);
            return (Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)val_14;
            label_8:
            Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters val_12 = null;
            val_14 = val_12;
            val_12 = new Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(algorithm:  val_13, q:  val_5, parameters:  val_1);
            return (Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)val_14;
        }
    
    }

}
