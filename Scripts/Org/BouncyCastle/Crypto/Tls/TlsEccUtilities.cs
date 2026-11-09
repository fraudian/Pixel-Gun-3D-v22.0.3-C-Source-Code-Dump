using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class TlsEccUtilities
    {
        // Fields
        private static readonly string[] CurveNames;
        
        // Methods
        public static void AddSupportedEllipticCurvesExtension(System.Collections.IDictionary extensions, int[] namedCurves)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            extensions.set_Item(key:  10, value:  Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CreateSupportedEllipticCurvesExtension(namedCurves:  namedCurves));
        }
        public static void AddSupportedPointFormatsExtension(System.Collections.IDictionary extensions, byte[] ecPointFormats)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            extensions.set_Item(key:  11, value:  Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CreateSupportedPointFormatsExtension(ecPointFormats:  ecPointFormats));
        }
        public static int[] GetSupportedEllipticCurvesExtension(System.Collections.IDictionary extensions)
        {
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  extensions, extensionType:  10);
            if(val_1 == null)
            {
                    return (System.Int32[])val_1;
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadSupportedEllipticCurvesExtension(extensionData:  val_1);
        }
        public static byte[] GetSupportedPointFormatsExtension(System.Collections.IDictionary extensions)
        {
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  extensions, extensionType:  11);
            if(val_1 == null)
            {
                    return val_1;
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadSupportedPointFormatsExtension(extensionData:  val_1);
        }
        public static byte[] CreateSupportedEllipticCurvesExtension(int[] namedCurves)
        {
            if((namedCurves != null) && (namedCurves.Length > 0))
            {
                    return Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeUint16ArrayWithUint16Length(uints:  namedCurves);
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static byte[] CreateSupportedPointFormatsExtension(byte[] ecPointFormats)
        {
            System.Byte[] val_3 = ecPointFormats;
            if(val_3 != null)
            {
                    if((Org.BouncyCastle.Utilities.Arrays.Contains(a:  val_3 = ecPointFormats, n:  0)) == true)
            {
                    return Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeUint8ArrayWithUint8Length(uints:  val_3 = Org.BouncyCastle.Utilities.Arrays.Append(a:  val_3, b:  0));
            }
            
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeUint8ArrayWithUint8Length(uints:  val_3);
        }
        public static int[] ReadSupportedEllipticCurvesExtension(byte[] extensionData)
        {
            var val_7;
            if(extensionData == null)
            {
                goto label_1;
            }
            
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  extensionData, writable:  false);
            int val_2 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input:  val_1);
            if((val_2 < 2) || ((val_2 & 1) != 0))
            {
                goto label_5;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf:  val_1);
            return (System.Int32[])Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16Array(count:  val_2 >> 1, input:  val_1);
            label_1:
            System.ArgumentNullException val_5 = null;
            val_7 = val_5;
            val_5 = new System.ArgumentNullException(paramName:  "extensionData");
            goto label_10;
            label_5:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_6 = null;
            val_7 = val_6;
            val_6 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  50);
            label_10:
        }
        public static byte[] ReadSupportedPointFormatsExtension(byte[] extensionData)
        {
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_9;
            var val_10;
            if(extensionData == null)
            {
                goto label_1;
            }
            
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  extensionData, writable:  false);
            byte val_2 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input:  val_1);
            if((val_2 & 255) == 0)
            {
                goto label_4;
            }
            
            System.Byte[] val_5 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8Array(count:  val_2 & 255, input:  val_1);
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf:  val_1);
            if((Org.BouncyCastle.Utilities.Arrays.Contains(a:  val_5, n:  0)) == false)
            {
                goto label_9;
            }
            
            return val_5;
            label_1:
            System.ArgumentNullException val_7 = null;
            val_9 = val_7;
            val_7 = new System.ArgumentNullException(paramName:  "extensionData");
            goto label_10;
            label_4:
            val_9 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_10 = 50;
            goto label_11;
            label_9:
            val_9 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_10 = 47;
            label_11:
            val_9 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
            label_10:
        }
        public static string GetNameOfNamedCurve(int namedCurve)
        {
            int val_4;
            var val_5;
            var val_6;
            val_4 = namedCurve;
            if((Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.IsSupportedNamedCurve(namedCurve:  val_4)) != false)
            {
                    val_5 = null;
                val_5 = null;
                val_4 = (long)val_4 - 1;
                System.String[] val_3 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CurveNames + (((long)(int)((namedCurve - 1))) << 3);
                val_6 = mem[(Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CurveNames + ((long)(int)((namedCurve - 1))) << 3) + 32];
                val_6 = (Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CurveNames + ((long)(int)((namedCurve - 1))) << 3) + 32;
                return (string)val_6;
            }
            
            val_6 = 0;
            return (string)val_6;
        }
        public static Org.BouncyCastle.Crypto.Parameters.ECDomainParameters GetParametersForNamedCurve(int namedCurve)
        {
            var val_10;
            var val_11;
            var val_12;
            string val_1 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GetNameOfNamedCurve(namedCurve:  namedCurve);
            if(val_1 != null)
            {
                    val_10 = Org.BouncyCastle.Crypto.EC.CustomNamedCurves.GetByName(name:  val_1);
                if(val_10 == null)
            {
                    val_11 = Org.BouncyCastle.Asn1.X9.ECNamedCurveTable.GetByName(name:  val_1);
                if(val_11 == null)
            {
                    return (Org.BouncyCastle.Crypto.Parameters.ECDomainParameters)val_12;
            }
            
            }
            
                Org.BouncyCastle.Crypto.Parameters.ECDomainParameters val_9 = null;
                val_12 = val_9;
                val_9 = new Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve:  val_11.Curve, g:  val_11.G, n:  val_11.N, h:  val_11.H, seed:  val_11.GetSeed());
                return (Org.BouncyCastle.Crypto.Parameters.ECDomainParameters)val_12;
            }
            
            val_12 = 0;
            return (Org.BouncyCastle.Crypto.Parameters.ECDomainParameters)val_12;
        }
        public static bool HasAnySupportedNamedCurves()
        {
            null = null;
            return (bool)(Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CurveNames.Length != 0) ? 1 : 0;
        }
        public static bool ContainsEccCipherSuites(int[] cipherSuites)
        {
            var val_2;
            var val_3;
            val_2 = 0;
            label_6:
            if(val_2 >= cipherSuites.Length)
            {
                goto label_2;
            }
            
            val_2 = val_2 + 1;
            if((Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.IsEccCipherSuite(cipherSuite:  cipherSuites[0])) == false)
            {
                goto label_6;
            }
            
            val_3 = 1;
            return (bool)val_3;
            label_2:
            val_3 = 0;
            return (bool)val_3;
        }
        public static bool IsEccCipherSuite(int cipherSuite)
        {
            var val_4;
            if(cipherSuite > 49307)
            {
                goto label_0;
            }
            
            if(cipherSuite > 49211)
            {
                goto label_1;
            }
            
            var val_4 = -49153;
            val_4 = cipherSuite + val_4;
            val_4 = 1;
            if(val_4 < 25)
            {
                    return (bool)val_4;
            }
            
            var val_5 = 49186;
            val_5 = cipherSuite + val_5;
            if(val_5 > 24)
            {
                goto label_9;
            }
            
            return (bool)val_4;
            label_0:
            if(cipherSuite > 52393)
            {
                goto label_5;
            }
            
            val_4 = 1;
            if((cipherSuite & 4294967292) == 49324)
            {
                    return (bool)val_4;
            }
            
            if((cipherSuite & 4294967294) != 52392)
            {
                goto label_9;
            }
            
            return (bool)val_4;
            label_1:
            var val_6 = 49265;
            val_6 = cipherSuite + val_6;
            if(val_6 >= 42)
            {
                goto label_9;
            }
            
            var val_7 = val_6;
            val_7 = 3298802270463 >> val_7;
            cipherSuite = val_7 & 1;
            return (bool)cipherSuite;
            label_5:
            int val_3 = cipherSuite + 65281;
            val_4 = 1;
            if(val_3 <= 19)
            {
                    val_3 = val_4 << val_3;
                val_3 = val_3 & 786447;
                if(val_3 != 0)
            {
                    return (bool)val_4;
            }
            
            }
            
            if(cipherSuite == 52396)
            {
                    return (bool)val_4;
            }
            
            label_9:
            val_4 = 0;
            return (bool)val_4;
        }
        public static bool AreOnSameCurve(Org.BouncyCastle.Crypto.Parameters.ECDomainParameters a, Org.BouncyCastle.Crypto.Parameters.ECDomainParameters b)
        {
            if(a == null)
            {
                    return (bool)a;
            }
            
            goto Org.BouncyCastle.Crypto.Parameters.ECDomainParameters.__il2cppRuntimeField_vtable;
        }
        public static bool IsSupportedNamedCurve(int namedCurve)
        {
            var val_2;
            var val_3;
            if(namedCurve >= 1)
            {
                    val_2 = null;
                val_2 = null;
                var val_1 = (Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CurveNames.Length >= namedCurve) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public static bool IsCompressionPreferred(byte[] ecPointFormats, byte compressionFormat)
        {
            var val_1;
            if(ecPointFormats == null)
            {
                    return (bool)val_1;
            }
            
            if(ecPointFormats.Length < 1)
            {
                goto label_3;
            }
            
            label_5:
            byte val_2 = ecPointFormats[0];
            if(val_2 == 0)
            {
                goto label_3;
            }
            
            if(val_2 == compressionFormat)
            {
                goto label_4;
            }
            
            if((0 + 1) < ecPointFormats.Length)
            {
                goto label_5;
            }
            
            label_3:
            val_1 = 0;
            return (bool)val_1;
            label_4:
            val_1 = 1;
            return (bool)val_1;
        }
        public static byte[] SerializeECFieldElement(int fieldSize, Org.BouncyCastle.Math.BigInteger x)
        {
            int val_1 = fieldSize + 7;
            fieldSize = ((val_1 < 0) ? (fieldSize + 14) : (val_1)) >> 3;
            return Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(length:  fieldSize, n:  x);
        }
        public static byte[] SerializeECPoint(byte[] ecPointFormats, Org.BouncyCastle.Math.EC.ECPoint point)
        {
            var val_4;
            System.Byte[] val_5;
            if((Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpCurve(c:  point)) == false)
            {
                goto label_2;
            }
            
            val_4 = 1;
            goto label_5;
            label_2:
            if((Org.BouncyCastle.Math.EC.ECAlgorithms.IsF2mCurve(c:  point)) == false)
            {
                goto label_6;
            }
            
            val_4 = 2;
            label_5:
            val_5 = ecPointFormats;
            bool val_3 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.IsCompressionPreferred(ecPointFormats:  val_5, compressionFormat:  2);
            goto label_9;
            label_6:
            val_5 = 0;
            label_9:
            var val_4 = val_5 & 1;
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_2B8;
        }
        public static byte[] SerializeECPublicKey(byte[] ecPointFormats, Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters keyParameters)
        {
            return Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.SerializeECPoint(ecPointFormats:  ecPointFormats, point:  keyParameters.Q);
        }
        public static Org.BouncyCastle.Math.BigInteger DeserializeECFieldElement(int fieldSize, byte[] encoding)
        {
            int val_6 = fieldSize;
            int val_1 = val_6 + 7;
            val_6 = ((val_1 < 0) ? (val_6 + 14) : (val_1)) >> 3;
            if(val_6 == encoding.Length)
            {
                    return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  encoding);
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_5 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  50);
        }
        public static Org.BouncyCastle.Math.EC.ECPoint DeserializeECPoint(byte[] ecPointFormats, Org.BouncyCastle.Math.EC.ECCurve curve, byte[] encoding)
        {
            Org.BouncyCastle.Math.EC.ECCurve val_6;
            System.Byte[] val_7;
            var val_8;
            val_6 = curve;
            val_7 = ecPointFormats;
            if((encoding == null) || (encoding.Length <= 0))
            {
                goto label_10;
            }
            
            byte val_6 = encoding[0];
            if((val_6 - 2) >= 2)
            {
                goto label_3;
            }
            
            if((Org.BouncyCastle.Math.EC.ECAlgorithms.IsF2mCurve(c:  val_6)) == false)
            {
                goto label_4;
            }
            
            val_8 = 2;
            if(val_7 != null)
            {
                goto label_5;
            }
            
            goto label_10;
            label_3:
            if(val_6 != 4)
            {
                goto label_10;
            }
            
            label_11:
            val_6 = ???;
            val_7 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECCurve).__il2cppRuntimeField_368;
            label_4:
            if((Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpCurve(c:  val_6)) == false)
            {
                goto label_10;
            }
            
            val_8 = 1;
            if(val_7 == 0)
            {
                goto label_10;
            }
            
            label_5:
            if((Org.BouncyCastle.Utilities.Arrays.Contains(a:  val_7, n:  1)) == true)
            {
                goto label_11;
            }
            
            label_10:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_5 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
        }
        public static Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters DeserializeECPublicKey(byte[] ecPointFormats, Org.BouncyCastle.Crypto.Parameters.ECDomainParameters curve_params, byte[] encoding)
        {
            new Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters() = new Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(q:  Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECPoint(ecPointFormats:  ecPointFormats, curve:  curve_params.Curve, encoding:  encoding), parameters:  curve_params);
            return (Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)new Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters();
        }
        public static byte[] CalculateECDHBasicAgreement(Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters publicKey, Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privateKey)
        {
            Org.BouncyCastle.Crypto.Agreement.ECDHBasicAgreement val_1 = new Org.BouncyCastle.Crypto.Agreement.ECDHBasicAgreement();
            if(val_1 != null)
            {
                    return Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(length:  -15134400, n:  val_1);
            }
            
            return Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(length:  -15134400, n:  val_1);
        }
        public static Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateECKeyPair(Org.BouncyCastle.Security.SecureRandom random, Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ecParams)
        {
            Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator val_1 = new Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator();
            Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters val_2 = new Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters(domainParameters:  ecParams, random:  random);
            if(val_1 != null)
            {
                    val_1.Init(parameters:  val_2);
                return val_1.GenerateKeyPair();
            }
            
            val_1.Init(parameters:  val_2);
            return val_1.GenerateKeyPair();
        }
        public static Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters GenerateEphemeralClientKeyExchange(Org.BouncyCastle.Security.SecureRandom random, byte[] ecPointFormats, Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ecParams, System.IO.Stream output)
        {
            var val_8;
            Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair val_1 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GenerateECKeyPair(random:  random, ecParams:  ecParams);
            Org.BouncyCastle.Crypto.AsymmetricKeyParameter val_2 = val_1.Public;
            Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECPoint(ecPointFormats:  ecPointFormats, point:  0.Q, output:  output);
            if(val_1.Private == null)
            {
                    return (Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)val_8;
            }
            
            val_8 = 0;
            return (Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)val_8;
        }
        internal static Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters GenerateEphemeralServerKeyExchange(Org.BouncyCastle.Security.SecureRandom random, int[] namedCurves, byte[] ecPointFormats, System.IO.Stream output)
        {
            int val_7;
            var val_8;
            if(namedCurves == null)
            {
                goto label_1;
            }
            
            if(namedCurves.Length < 1)
            {
                goto label_2;
            }
            
            label_9:
            val_7 = namedCurves[0];
            namedCurves[0] = val_7 - 1;
            if(namedCurves[0] >= 28)
            {
                    if((val_7 + (-65281)) > 1)
            {
                goto label_5;
            }
            
            }
            
            if((Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.IsSupportedNamedCurve(namedCurve:  val_7)) == true)
            {
                goto label_8;
            }
            
            label_5:
            if((0 + 1) < namedCurves.Length)
            {
                goto label_9;
            }
            
            label_2:
            if((Org.BouncyCastle.Utilities.Arrays.Contains(a:  namedCurves, n:  1)) == false)
            {
                goto label_10;
            }
            
            val_8 = 23;
            goto label_13;
            label_1:
            val_7 = 23;
            label_8:
            val_8 = 23;
            goto label_16;
            label_10:
            if((Org.BouncyCastle.Utilities.Arrays.Contains(a:  namedCurves, n:  2)) == false)
            {
                goto label_20;
            }
            
            val_8 = 10;
            label_13:
            val_7 = 0;
            label_16:
            Org.BouncyCastle.Crypto.Parameters.ECDomainParameters val_6 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GetParametersForNamedCurve(namedCurve:  10);
            if(val_6 != null)
            {
                    if((val_7 & 2147483648) == 0)
            {
                    Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteNamedECParameters(namedCurve:  0, output:  output);
                return Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GenerateEphemeralClientKeyExchange(random:  random, ecPointFormats:  ecPointFormats, ecParams:  val_6, output:  output);
            }
            
                Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteExplicitECParameters(ecPointFormats:  ecPointFormats, ecParameters:  val_6, output:  output);
                return Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GenerateEphemeralClientKeyExchange(random:  random, ecPointFormats:  ecPointFormats, ecParams:  val_6, output:  output);
            }
            
            label_20:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_7 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ValidateECPublicKey(Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters key)
        {
            return (Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)key;
        }
        public static int ReadECExponent(int fieldSize, System.IO.Stream input)
        {
            Org.BouncyCastle.Math.BigInteger val_1 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameter(input:  input);
            if(val_1.BitLength <= 31)
            {
                    int val_3 = val_1.IntValue;
                if((val_3 >= 1) && (val_3 < fieldSize))
            {
                    return val_3;
            }
            
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_4 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
        }
        public static Org.BouncyCastle.Math.BigInteger ReadECFieldElement(int fieldSize, System.IO.Stream input)
        {
            return Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECFieldElement(fieldSize:  fieldSize, encoding:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input:  input));
        }
        public static Org.BouncyCastle.Math.BigInteger ReadECParameter(System.IO.Stream input)
        {
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input:  input));
        }
        public static Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ReadECParameters(int[] namedCurves, byte[] ecPointFormats, System.IO.Stream input)
        {
            System.Byte[] val_42;
            System.Int32[] val_43;
            Org.BouncyCastle.Math.BigInteger val_44;
            Org.BouncyCastle.Math.EC.FpCurve val_45;
            Org.BouncyCastle.Crypto.Parameters.ECDomainParameters val_46;
            var val_47;
            int val_48;
            var val_49;
            var val_50;
            val_42 = ecPointFormats;
            val_43 = namedCurves;
            byte val_2 = (Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input:  input)) & 255;
            if(val_2 == 3)
            {
                goto label_3;
            }
            
            if(val_2 == 2)
            {
                goto label_4;
            }
            
            if(val_2 != 1)
            {
                goto label_5;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CheckNamedCurve(namedCurves:  val_43, namedCurve:  1);
            Org.BouncyCastle.Math.BigInteger val_3 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameter(input:  input);
            val_44 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECFieldElement(fieldSize:  val_3.BitLength, input:  input);
            Org.BouncyCastle.Math.BigInteger val_9 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameter(input:  input);
            Org.BouncyCastle.Math.BigInteger val_10 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameter(input:  input);
            val_45 = new Org.BouncyCastle.Math.EC.FpCurve();
            val_45 = new Org.BouncyCastle.Math.EC.FpCurve(q:  val_3, a:  Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECFieldElement(fieldSize:  val_3.BitLength, input:  input), b:  val_44, order:  val_9, cofactor:  val_10);
            val_43 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECPoint(ecPointFormats:  val_42, curve:  new Org.BouncyCastle.Math.EC.FpCurve(), encoding:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input:  input));
            val_46 = new Org.BouncyCastle.Crypto.Parameters.ECDomainParameters();
            val_46 = new Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve:  new Org.BouncyCastle.Math.EC.FpCurve(), g:  val_43, n:  val_9, h:  val_10);
            return val_46;
            label_3:
            int val_14 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input:  input);
            var val_42 = -65281;
            val_42 = val_14 + val_42;
            if(val_42 <= 1)
            {
                goto label_15;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CheckNamedCurve(namedCurves:  val_43, namedCurve:  val_14);
            val_46 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GetParametersForNamedCurve(namedCurve:  val_14);
            return val_46;
            label_4:
            Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CheckNamedCurve(namedCurves:  val_43, namedCurve:  2);
            int val_16 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input:  input);
            val_47 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input:  input);
            byte val_18 = val_47 - 1;
            if((val_18 & 255) >= 2)
            {
                goto label_23;
            }
            
            int val_20 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECExponent(fieldSize:  val_16, input:  input);
            val_48 = 0;
            if((val_18 & 255) > 1)
            {
                goto label_26;
            }
            
            val_45 = 0;
            if((val_47 & 255) != 2)
            {
                goto label_30;
            }
            
            val_45 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECExponent(fieldSize:  val_16, input:  input);
            val_48 = val_16;
            int val_24 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECExponent(fieldSize:  val_48, input:  input);
            val_47 = 2;
            goto label_30;
            label_26:
            val_45 = 0;
            label_30:
            Org.BouncyCastle.Math.BigInteger val_25 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECFieldElement(fieldSize:  val_16, input:  input);
            Org.BouncyCastle.Math.BigInteger val_26 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECFieldElement(fieldSize:  val_16, input:  input);
            val_42 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input:  input);
            Org.BouncyCastle.Math.BigInteger val_28 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameter(input:  input);
            Org.BouncyCastle.Math.BigInteger val_29 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameter(input:  input);
            if((val_47 & 255) == 2)
            {
                    val_44 = new Org.BouncyCastle.Math.EC.F2mCurve();
                val_44 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  val_16, k1:  val_20, k2:  0, k3:  0, a:  val_25, b:  val_26, order:  val_28, cofactor:  val_29);
            }
            else
            {
                    val_44 = new Org.BouncyCastle.Math.EC.F2mCurve();
                val_44 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  val_16, k:  val_20, a:  val_25, b:  val_26, order:  val_28, cofactor:  val_29);
            }
            
            val_43 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECPoint(ecPointFormats:  val_42, curve:  new Org.BouncyCastle.Math.EC.F2mCurve(), encoding:  val_42);
            val_46 = new Org.BouncyCastle.Crypto.Parameters.ECDomainParameters();
            val_46 = new Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve:  new Org.BouncyCastle.Math.EC.F2mCurve(), g:  val_43, n:  val_28, h:  val_29);
            return val_46;
            label_5:
            new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert() = new System.IO.IOException(message:  Org.BouncyCastle.Crypto.Tls.AlertDescription.GetText(alertDescription:  47), innerException:  0);
            .alertDescription = 47;
            label_15:
            new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert() = new System.IO.IOException(message:  Org.BouncyCastle.Crypto.Tls.AlertDescription.GetText(alertDescription:  47), innerException:  0);
            .alertDescription = 47;
            label_23:
            new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert() = new System.IO.IOException(message:  Org.BouncyCastle.Crypto.Tls.AlertDescription.GetText(alertDescription:  47), innerException:  0);
            .alertDescription = 47;
            val_49 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            if(0 == 1)
            {
                    val_50 = val_49;
                if((null & 1) != 0)
            {
                    Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_41 = null;
                val_50 = val_41;
                val_41 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47, alertCause:  1152921505528889344);
            }
            
                mem[8] = null;
                val_49 = 8;
            }
        
        }
        private static void CheckNamedCurve(int[] namedCurves, int namedCurve)
        {
            if(namedCurves == null)
            {
                    return;
            }
            
            if((Org.BouncyCastle.Utilities.Arrays.Contains(a:  namedCurves, n:  namedCurve)) != false)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
        }
        public static void WriteECExponent(int k, System.IO.Stream output)
        {
            Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECParameter(x:  Org.BouncyCastle.Math.BigInteger.ValueOf(value:  (long)k), output:  output);
        }
        public static void WriteECFieldElement(Org.BouncyCastle.Math.EC.ECFieldElement x, System.IO.Stream output)
        {
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(buf:  x, output:  output);
        }
        public static void WriteECFieldElement(int fieldSize, Org.BouncyCastle.Math.BigInteger x, System.IO.Stream output)
        {
            int val_1 = fieldSize + 7;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(buf:  Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(length:  ((val_1 < 0) ? (fieldSize + 14) : (val_1)) >> 3, n:  x), output:  output);
        }
        public static void WriteECParameter(Org.BouncyCastle.Math.BigInteger x, System.IO.Stream output)
        {
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(buf:  Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(n:  x), output:  output);
        }
        public static void WriteExplicitECParameters(byte[] ecPointFormats, Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ecParameters, System.IO.Stream output)
        {
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            int val_20;
            string val_22;
            var val_23;
            Org.BouncyCastle.Math.EC.ECCurve val_1 = ecParameters.Curve;
            if((Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpCurve(c:  val_1)) == false)
            {
                goto label_2;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  1, output:  output);
            var val_17 = 0;
            val_17 = val_17 + 1;
            goto label_10;
            label_2:
            if((Org.BouncyCastle.Math.EC.ECAlgorithms.IsF2mCurve(c:  val_1)) == false)
            {
                goto label_11;
            }
            
            if(val_1 == null)
            {
                goto label_13;
            }
            
            val_16 = null;
            val_15 = val_16;
            val_17 = val_1;
            if(val_17 != null)
            {
                goto label_15;
            }
            
            val_15 = 0;
            goto label_16;
            label_13:
            val_16 = null;
            label_16:
            val_17 = 0;
            label_15:
            if(mem[282584257676957] == 0)
            {
                goto label_17;
            }
            
            var val_18 = mem[282584257676847];
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_19:
            if(((mem[282584257676847] + 8) + -8) == val_16)
            {
                goto label_18;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < mem[282584257676957])
            {
                goto label_19;
            }
            
            label_17:
            val_15 = val_16;
            goto label_20;
            label_10:
            Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECParameter(x:  val_1.Characteristic, output:  output);
            if(val_1 != null)
            {
                goto label_55;
            }
            
            label_56:
            label_55:
            Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECFieldElement(x:  val_1, output:  output);
            Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECFieldElement(x:  val_1, output:  output);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(buf:  Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.SerializeECPoint(ecPointFormats:  ecPointFormats, point:  ecParameters.G), output:  output);
            if(ecParameters != null)
            {
                    Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECParameter(x:  ecParameters.N, output:  output);
            }
            else
            {
                    Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECParameter(x:  0.N, output:  output);
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECParameter(x:  ecParameters.H, output:  output);
            return;
            label_18:
            val_17 = val_17 + (((mem[282584257676847] + 8)) << 4);
            val_18 = val_17 + 296;
            label_20:
            var val_20 = 0;
            val_20 = val_20 + 1;
            System.Int32[] val_14 = val_17.MinimalPolynomial.GetExponentsPresent();
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  2, output:  output);
            var val_21 = -4294967296;
            val_21 = val_21 + ((val_14.Length) << 32);
            var val_15 = val_21 >> 32;
            int val_22 = val_14[(((-4294967296 + (val_14.Length) << 32) >> 32)) << 2];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i:  val_22);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  val_22, output:  output);
            if(val_14.Length == 5)
            {
                goto label_40;
            }
            
            if(val_14.Length != 3)
            {
                goto label_41;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  1, output:  output);
            val_20 = val_14[0];
            goto label_47;
            label_40:
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  2, output:  output);
            Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECExponent(k:  val_14[0], output:  output);
            Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECExponent(k:  val_14[1], output:  output);
            val_20 = val_14[1];
            label_47:
            Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECExponent(k:  val_20, output:  output);
            if(val_1 != null)
            {
                goto label_55;
            }
            
            goto label_56;
            label_11:
            val_22 = "\'ecParameters\' not a known curve type";
            goto label_57;
            label_41:
            System.ArgumentException val_16 = null;
            val_22 = "Only trinomial and pentomial curves are supported";
            label_57:
            val_16 = new System.ArgumentException(message:  val_22);
            val_23 = val_16;
        }
        public static void WriteECPoint(byte[] ecPointFormats, Org.BouncyCastle.Math.EC.ECPoint point, System.IO.Stream output)
        {
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(buf:  Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.SerializeECPoint(ecPointFormats:  ecPointFormats, point:  point), output:  output);
        }
        public static void WriteNamedECParameters(int namedCurve, System.IO.Stream output)
        {
            var val_2 = -65281;
            val_2 = namedCurve + val_2;
            if(val_2 > 1)
            {
                    Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  3, output:  output);
                Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i:  namedCurve);
                Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  namedCurve, output:  output);
                return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        protected TlsEccUtilities()
        {
        
        }
        private static TlsEccUtilities()
        {
            string[] val_1 = new string[28];
            val_1[0] = "sect163k1";
            val_1[1] = "sect163r1";
            val_1[2] = "sect163r2";
            val_1[3] = "sect193r1";
            val_1[4] = "sect193r2";
            val_1[5] = "sect233k1";
            val_1[6] = "sect233r1";
            val_1[7] = "sect239k1";
            val_1[8] = "sect283k1";
            val_1[9] = "sect283r1";
            val_1[10] = "sect409k1";
            val_1[11] = "sect409r1";
            val_1[12] = "sect571k1";
            val_1[13] = "sect571r1";
            val_1[14] = "secp160k1";
            val_1[15] = "secp160r1";
            val_1[16] = "secp160r2";
            val_1[17] = "secp192k1";
            val_1[18] = "secp192r1";
            val_1[19] = "secp224k1";
            val_1[20] = "secp224r1";
            val_1[21] = "secp256k1";
            val_1[22] = "secp256r1";
            val_1[23] = "secp384r1";
            val_1[24] = "secp521r1";
            val_1[25] = "brainpoolP256r1";
            val_1[26] = "brainpoolP384r1";
            val_1[27] = "brainpoolP512r1";
            Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CurveNames = val_1;
        }
    
    }

}
