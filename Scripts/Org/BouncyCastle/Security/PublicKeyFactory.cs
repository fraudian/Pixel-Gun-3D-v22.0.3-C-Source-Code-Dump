using UnityEngine;

namespace Org.BouncyCastle.Security
{
    public sealed class PublicKeyFactory
    {
        // Methods
        private PublicKeyFactory()
        {
        
        }
        public static Org.BouncyCastle.Crypto.AsymmetricKeyParameter CreateKey(byte[] keyInfoData)
        {
            return Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(keyInfo:  Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(data:  keyInfoData)));
        }
        public static Org.BouncyCastle.Crypto.AsymmetricKeyParameter CreateKey(System.IO.Stream inStr)
        {
            return Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(keyInfo:  Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Object.FromStream(inStr:  inStr)));
        }
        public static Org.BouncyCastle.Crypto.AsymmetricKeyParameter CreateKey(Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo keyInfo)
        {
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_128;
            var val_129;
            var val_130;
            var val_131;
            var val_132;
            Org.BouncyCastle.Math.BigInteger val_133;
            var val_134;
            Org.BouncyCastle.Asn1.Asn1Sequence val_135;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_136;
            Org.BouncyCastle.Math.BigInteger val_137;
            var val_138;
            Org.BouncyCastle.Crypto.Parameters.DHValidationParameters val_139;
            var val_140;
            var val_141;
            var val_142;
            var val_143;
            var val_144;
            var val_145;
            Org.BouncyCastle.Math.BigInteger val_146;
            Org.BouncyCastle.Math.BigInteger val_147;
            Org.BouncyCastle.Math.BigInteger val_148;
            var val_149;
            var val_150;
            Org.BouncyCastle.Crypto.Parameters.DsaParameters val_151;
            var val_152;
            Org.BouncyCastle.Asn1.Asn1Sequence val_153;
            var val_154;
            var val_155;
            Org.BouncyCastle.Math.EC.ECPoint val_156;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_157;
            string val_158;
            var val_159;
            Org.BouncyCastle.Asn1.Asn1Sequence val_160;
            var val_161;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_162;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_163;
            Org.BouncyCastle.Asn1.Asn1Sequence val_164;
            Org.BouncyCastle.Math.EC.ECCurve val_165;
            Org.BouncyCastle.Math.EC.ECPoint val_166;
            Org.BouncyCastle.Math.BigInteger val_167;
            Org.BouncyCastle.Math.BigInteger val_168;
            string val_169;
            var val_170;
            var val_171;
            bool val_173;
            var val_175;
            Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier val_1 = keyInfo.AlgorithmID;
            val_128 = val_1;
            val_129 = null;
            val_129 = null;
            if((val_128.Equals(obj:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs12PbeIds)) == true)
            {
                goto label_12;
            }
            
            val_130 = null;
            val_130 = null;
            if((val_128.Equals(obj:  Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdEARsa)) == true)
            {
                goto label_12;
            }
            
            val_131 = null;
            val_131 = null;
            if((val_128.Equals(obj:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss)) == true)
            {
                goto label_12;
            }
            
            val_132 = null;
            val_132 = null;
            if((val_128.Equals(obj:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsaesOaep)) == false)
            {
                goto label_15;
            }
            
            label_12:
            Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure val_7 = Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure.GetInstance(obj:  keyInfo.GetPublicKey());
            if(val_7 != null)
            {
                    val_133 = val_7.Modulus;
            }
            else
            {
                    val_133 = 0.Modulus;
            }
            
            return (Org.BouncyCastle.Crypto.AsymmetricKeyParameter)new Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(isPrivate:  false, modulus:  val_133, exponent:  val_7.PublicExponent);
            label_15:
            val_134 = null;
            val_134 = null;
            if((val_128.Equals(obj:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHPublicNumber)) == false)
            {
                goto label_21;
            }
            
            val_135 = Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_1);
            Org.BouncyCastle.Math.BigInteger val_17 = Org.BouncyCastle.Asn1.X9.DHPublicKey.GetInstance(obj:  keyInfo.GetPublicKey()).Y.Value;
            if((Org.BouncyCastle.Security.PublicKeyFactory.IsPkcsDHParam(seq:  val_135)) == false)
            {
                goto label_26;
            }
            
            val_136 = val_128;
            val_137 = val_17;
            goto label_27;
            label_21:
            val_138 = null;
            val_138 = null;
            if((val_128.Equals(obj:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DhKeyAgreement)) == false)
            {
                goto label_30;
            }
            
            val_135 = Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_1);
            Org.BouncyCastle.Asn1.Asn1Object val_21 = keyInfo.GetPublicKey();
            val_137 = 0.Value;
            val_136 = val_128;
            label_27:
            Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters val_25 = Org.BouncyCastle.Security.PublicKeyFactory.ReadPkcsDHParam(algOid:  val_136, y:  val_137, seq:  val_135);
            return (Org.BouncyCastle.Crypto.AsymmetricKeyParameter)new Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(isPrivate:  false, modulus:  val_133, exponent:  val_7.PublicExponent);
            label_26:
            Org.BouncyCastle.Asn1.X9.DHDomainParameters val_26 = Org.BouncyCastle.Asn1.X9.DHDomainParameters.GetInstance(obj:  val_135);
            if(val_26.J == null)
            {
                goto label_44;
            }
            
            if(val_26 != null)
            {
                goto label_77;
            }
            
            label_78:
            label_77:
            val_139 = val_26.ValidationParms;
            if(val_139 != null)
            {
                    Org.BouncyCastle.Crypto.Parameters.DHValidationParameters val_41 = null;
                val_139 = val_41;
                val_41 = new Org.BouncyCastle.Crypto.Parameters.DHValidationParameters(seed:  val_139.Seed, counter:  val_139.PgenCounter.Value.IntValue);
            }
            
            Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters val_43 = new Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(y:  val_17, parameters:  new Org.BouncyCastle.Crypto.Parameters.DHParameters(p:  val_26.P.Value, g:  val_26.G.Value, q:  val_26.Q.Value, j:  val_26.J.Value, validation:  val_41));
            return (Org.BouncyCastle.Crypto.AsymmetricKeyParameter)new Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(isPrivate:  false, modulus:  val_133, exponent:  val_7.PublicExponent);
            label_30:
            val_140 = null;
            val_140 = null;
            if((val_128.Equals(obj:  Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.ElGamalAlgorithm)) == false)
            {
                goto label_55;
            }
            
            Org.BouncyCastle.Asn1.Oiw.ElGamalParameter val_46 = new Org.BouncyCastle.Asn1.Oiw.ElGamalParameter(seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_1));
            val_141 = keyInfo.GetPublicKey();
            if(val_141 == null)
            {
                goto label_58;
            }
            
            val_141 = 0;
            goto label_63;
            label_55:
            val_142 = null;
            val_142 = null;
            if((val_128.Equals(obj:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsa)) == true)
            {
                goto label_66;
            }
            
            val_143 = null;
            val_143 = null;
            if((val_128.Equals(obj:  Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DsaWithSha1)) == false)
            {
                goto label_69;
            }
            
            label_66:
            if(keyInfo.GetPublicKey() != null)
            {
                    val_144 = 0;
            }
            
            val_145 = 0;
            if(val_1 == null)
            {
                goto label_74;
            }
            
            Org.BouncyCastle.Asn1.X509.DsaParameter val_54 = Org.BouncyCastle.Asn1.X509.DsaParameter.GetInstance(obj:  val_1);
            if(val_54 == null)
            {
                goto label_75;
            }
            
            val_146 = val_54.P;
            val_147 = val_54.Q;
            goto label_76;
            label_44:
            if(val_26 != null)
            {
                goto label_77;
            }
            
            goto label_78;
            label_58:
            label_63:
            if(val_46 != null)
            {
                    val_148 = val_46.P;
            }
            else
            {
                    val_148 = val_46.P;
            }
            
            Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters val_62 = new Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters(y:  val_141.Value, parameters:  new Org.BouncyCastle.Crypto.Parameters.ElGamalParameters(p:  val_148, g:  val_46.G));
            return (Org.BouncyCastle.Crypto.AsymmetricKeyParameter)new Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(isPrivate:  false, modulus:  val_133, exponent:  val_7.PublicExponent);
            label_69:
            val_149 = null;
            val_149 = null;
            if((val_128.Equals(obj:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdECPublicKey)) == false)
            {
                goto label_84;
            }
            
            Org.BouncyCastle.Asn1.X9.X962Parameters val_64 = new Org.BouncyCastle.Asn1.X9.X962Parameters(obj:  val_1);
            if(val_64 == null)
            {
                goto label_86;
            }
            
            val_150 = val_64.IsNamedCurve;
            goto label_87;
            label_75:
            val_146 = 0.P;
            val_147 = 0.Q;
            label_76:
            Org.BouncyCastle.Crypto.Parameters.DsaParameters val_69 = null;
            val_151 = val_69;
            val_69 = new Org.BouncyCastle.Crypto.Parameters.DsaParameters(p:  val_146, q:  val_147, g:  val_54.G);
            if(val_145 != 0)
            {
                goto label_165;
            }
            
            goto label_89;
            label_84:
            val_152 = null;
            val_152 = null;
            if((val_128.Equals(obj:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001)) == false)
            {
                goto label_92;
            }
            
            val_153 = val_1;
            val_128 = new Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters();
            if(val_153 != null)
            {
                    val_153 = 0;
            }
            
            val_128 = new Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters(seq:  val_153);
            Org.BouncyCastle.Asn1.Asn1Object val_73 = keyInfo.GetPublicKey();
            if(val_73 == null)
            {
                goto label_168;
            }
            
            byte[] val_75 = new byte[32];
            byte[] val_76 = new byte[32];
            val_154 = 0;
            goto label_100;
            label_106:
            Org.BouncyCastle.Asn1.Asn1Object val_77 = val_73 + 31;
            val_154 = 1;
            val_75[0] = 31;
            label_100:
            if(val_154 != val_76.Length)
            {
                goto label_106;
            }
            
            val_155 = 0;
            goto label_107;
            label_112:
            Org.BouncyCastle.Asn1.Asn1Object val_78 = val_73 + 63;
            val_155 = 1;
            val_76[0] = 63;
            label_107:
            if(val_155 != val_75.Length)
            {
                goto label_112;
            }
            
            Org.BouncyCastle.Crypto.Parameters.ECDomainParameters val_80 = Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.GetByOid(oid:  new Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters().PublicKeyParamSet);
            if(val_80 == null)
            {
                    return (Org.BouncyCastle.Crypto.AsymmetricKeyParameter)new Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(isPrivate:  false, modulus:  val_133, exponent:  val_7.PublicExponent);
            }
            
            Org.BouncyCastle.Math.BigInteger val_82 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_75);
            Org.BouncyCastle.Math.BigInteger val_83 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_76);
            val_156 = val_80.Curve;
            val_157 = new Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters().PublicKeyParamSet;
            val_158 = "ECGOST3410";
            goto label_119;
            label_74:
            val_145 = 0;
            val_151 = 0;
            label_89:
            label_165:
            Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters val_87 = new Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters(y:  val_145.Value, parameters:  val_151);
            return (Org.BouncyCastle.Crypto.AsymmetricKeyParameter)new Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(isPrivate:  false, modulus:  val_133, exponent:  val_7.PublicExponent);
            label_92:
            val_159 = null;
            val_159 = null;
            if((val_128.Equals(obj:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94)) == false)
            {
                goto label_127;
            }
            
            val_160 = val_1;
            val_128 = new Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters();
            if(val_160 != null)
            {
                    val_160 = 0;
            }
            
            val_128 = new Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters(seq:  val_160);
            Org.BouncyCastle.Asn1.Asn1Object val_91 = keyInfo.GetPublicKey();
            if(val_91 == null)
            {
                goto label_168;
            }
            
            byte[] val_93 = new byte[0];
            if(null != 0)
            {
                    var val_128 = 0;
                var val_129 = 0;
                do
            {
                Org.BouncyCastle.Asn1.Asn1Object val_94 = val_91 + 136111552;
                val_93[0] = 136111552;
                val_128 = val_128 + 1;
                val_129 = val_129 - 1;
            }
            while(val_128 != val_93[0]);
            
            }
            
            Org.BouncyCastle.Crypto.Parameters.Gost3410PublicKeyParameters val_97 = new Org.BouncyCastle.Crypto.Parameters.Gost3410PublicKeyParameters(y:  new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_93), publicKeyParamSet:  new Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters().PublicKeyParamSet);
            return (Org.BouncyCastle.Crypto.AsymmetricKeyParameter)new Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(isPrivate:  false, modulus:  val_133, exponent:  val_7.PublicExponent);
            label_86:
            val_150 = val_64.IsNamedCurve;
            label_87:
            val_161 = val_64.Parameters;
            if(val_150 == false)
            {
                goto label_143;
            }
            
            if(val_161 != null)
            {
                    val_162 = 0;
            }
            
            Org.BouncyCastle.Asn1.X9.X9ECParameters val_101 = Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator.FindECCurveByOid(oid:  val_162);
            if(keyInfo != null)
            {
                goto label_161;
            }
            
            label_162:
            label_161:
            Org.BouncyCastle.Math.EC.ECPoint val_106 = new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_101.Curve, s:  new Org.BouncyCastle.Asn1.DerOctetString(str:  keyInfo.PublicKeyData)).Point;
            if(val_64.IsNamedCurve == false)
            {
                goto label_152;
            }
            
            val_163 = val_64.Parameters;
            if(val_163 != null)
            {
                    val_163 = 0;
            }
            
            val_158 = "EC";
            val_156 = val_106;
            val_157 = val_163;
            label_119:
            new Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters() = new Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(algorithm:  val_158, q:  val_156, publicKeyParamSet:  val_157);
            return (Org.BouncyCastle.Crypto.AsymmetricKeyParameter)new Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(isPrivate:  false, modulus:  val_133, exponent:  val_7.PublicExponent);
            label_143:
            if(val_161 != null)
            {
                    val_164 = 0;
            }
            
            new Org.BouncyCastle.Asn1.X9.X9ECParameters() = new Org.BouncyCastle.Asn1.X9.X9ECParameters(seq:  val_164);
            if(keyInfo != null)
            {
                goto label_161;
            }
            
            goto label_162;
            label_152:
            if(val_101 != null)
            {
                    val_165 = val_101.Curve;
                val_166 = val_101.G;
                val_167 = val_101.N;
                val_168 = val_101.H;
            }
            else
            {
                    val_165 = 0.Curve;
                val_166 = 0.G;
                val_167 = 0.N;
                val_168 = 0.H;
            }
            
            Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters val_123 = new Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(q:  val_106, parameters:  new Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve:  val_165, g:  val_166, n:  val_167, h:  val_168, seed:  val_101.GetSeed()));
            return (Org.BouncyCastle.Crypto.AsymmetricKeyParameter)new Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(isPrivate:  false, modulus:  val_133, exponent:  val_7.PublicExponent);
            label_168:
            label_127:
            val_169 = "algorithm identifier in key not recognised: "("algorithm identifier in key not recognised: ") + new Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters();
            val_170 = 1152921543927611280;
            val_171 = new Org.BouncyCastle.Security.SecurityUtilityException(message:  val_169);
            val_175 = 8;
            mem[8] = null;
            val_173 = val_175;
        }
        private static bool IsPkcsDHParam(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            object val_9;
            var val_10;
            val_9 = seq;
            if(val_9 == 2)
            {
                    val_10 = 1;
                return (bool)val_10;
            }
            
            if(val_9 <= 3)
            {
                    val_9 = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  val_9).Value;
                var val_8 = ((val_9.CompareTo(value:  Org.BouncyCastle.Math.BigInteger.ValueOf(value:  (long)Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  val_9).Value.BitLength))) < 1) ? 1 : 0;
                return (bool)val_10;
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        private static Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters ReadPkcsDHParam(Org.BouncyCastle.Asn1.DerObjectIdentifier algOid, Org.BouncyCastle.Math.BigInteger y, Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            var val_9;
            Org.BouncyCastle.Math.BigInteger val_10;
            Org.BouncyCastle.Asn1.Pkcs.DHParameter val_1 = new Org.BouncyCastle.Asn1.Pkcs.DHParameter(seq:  seq);
            Org.BouncyCastle.Math.BigInteger val_2 = val_1.L;
            if(val_2 == null)
            {
                goto label_2;
            }
            
            val_9 = val_2.IntValue;
            if(val_1 == null)
            {
                goto label_3;
            }
            
            label_5:
            val_10 = val_1.P;
            return (Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters)new Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(y:  y, parameters:  new Org.BouncyCastle.Crypto.Parameters.DHParameters(p:  val_10 = val_1.P, g:  val_1.G, q:  0, l:  0), algorithmOid:  algOid);
            label_2:
            val_9 = 0;
            if(val_1 != null)
            {
                goto label_5;
            }
            
            label_3:
            return (Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters)new Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(y:  y, parameters:  new Org.BouncyCastle.Crypto.Parameters.DHParameters(p:  val_10, g:  val_1.G, q:  0, l:  0), algorithmOid:  algOid);
        }
    
    }

}
