using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class TlsDHUtilities
    {
        // Fields
        internal static readonly Org.BouncyCastle.Math.BigInteger Two;
        private static readonly string draft_ffdhe2432_p;
        internal static readonly Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe2432;
        private static readonly string draft_ffdhe3072_p;
        internal static readonly Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe3072;
        private static readonly string draft_ffdhe4096_p;
        internal static readonly Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe4096;
        private static readonly string draft_ffdhe6144_p;
        internal static readonly Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe6144;
        private static readonly string draft_ffdhe8192_p;
        internal static readonly Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe8192;
        
        // Methods
        private static Org.BouncyCastle.Math.BigInteger FromHex(string hex)
        {
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  hex));
        }
        private static Org.BouncyCastle.Crypto.Parameters.DHParameters FromSafeP(string hexP)
        {
            Org.BouncyCastle.Math.BigInteger val_1 = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.FromHex(hex:  hexP);
            return (Org.BouncyCastle.Crypto.Parameters.DHParameters)new Org.BouncyCastle.Crypto.Parameters.DHParameters(p:  val_1, g:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.Two, q:  val_1.ShiftRight(n:  1));
        }
        public static void AddNegotiatedDheGroupsClientExtension(System.Collections.IDictionary extensions, byte[] dheGroups)
        {
            var val_3 = null;
            var val_3 = 0;
            val_3 = val_3 + 1;
            extensions.set_Item(key:  Org.BouncyCastle.Crypto.Tls.ExtensionType.renegotiation_info, value:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.CreateNegotiatedDheGroupsClientExtension(dheGroups:  dheGroups));
        }
        public static void AddNegotiatedDheGroupsServerExtension(System.Collections.IDictionary extensions, byte dheGroup)
        {
            var val_3 = null;
            var val_3 = 0;
            val_3 = val_3 + 1;
            extensions.set_Item(key:  Org.BouncyCastle.Crypto.Tls.ExtensionType.renegotiation_info, value:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.CreateNegotiatedDheGroupsServerExtension(dheGroup:  dheGroup));
        }
        public static byte[] GetNegotiatedDheGroupsClientExtension(System.Collections.IDictionary extensions)
        {
            null = null;
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  extensions, extensionType:  Org.BouncyCastle.Crypto.Tls.ExtensionType.renegotiation_info);
            if(val_1 == null)
            {
                    return val_1;
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadNegotiatedDheGroupsClientExtension(extensionData:  val_1);
        }
        public static short GetNegotiatedDheGroupsServerExtension(System.Collections.IDictionary extensions)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  extensions, extensionType:  Org.BouncyCastle.Crypto.Tls.ExtensionType.renegotiation_info);
            if(val_1 != null)
            {
                    val_4 = (Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadNegotiatedDheGroupsServerExtension(extensionData:  val_1)) & 255;
                return (short)val_4;
            }
            
            val_4 = 65535;
            return (short)val_4;
        }
        public static byte[] CreateNegotiatedDheGroupsClientExtension(byte[] dheGroups)
        {
            if(dheGroups != null)
            {
                    int val_2 = dheGroups.Length;
                val_2 = val_2 - 1;
                if(val_2 < 255)
            {
                    return Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeUint8ArrayWithUint8Length(uints:  dheGroups);
            }
            
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static byte[] CreateNegotiatedDheGroupsServerExtension(byte dheGroup)
        {
            byte[] val_1 = new byte[1];
            val_1[0] = dheGroup;
            return (System.Byte[])val_1;
        }
        public static byte[] ReadNegotiatedDheGroupsClientExtension(byte[] extensionData)
        {
            var val_8;
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
            
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf:  val_1);
            return (System.Byte[])Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8Array(count:  val_2 & 255, input:  val_1);
            label_1:
            System.ArgumentNullException val_6 = null;
            val_8 = val_6;
            val_6 = new System.ArgumentNullException(paramName:  "extensionData");
            goto label_9;
            label_4:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_7 = null;
            val_8 = val_7;
            val_7 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  50);
            label_9:
        }
        public static byte ReadNegotiatedDheGroupsServerExtension(byte[] extensionData)
        {
            var val_3;
            if(extensionData == null)
            {
                goto label_1;
            }
            
            if(extensionData.Length != 1)
            {
                goto label_2;
            }
            
            return (byte)extensionData[0];
            label_1:
            System.ArgumentNullException val_1 = null;
            val_3 = val_1;
            val_1 = new System.ArgumentNullException(paramName:  "extensionData");
            goto label_3;
            label_2:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = null;
            val_3 = val_2;
            val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  50);
            label_3:
        }
        public static Org.BouncyCastle.Crypto.Parameters.DHParameters GetParametersForDHEGroup(short dheGroup)
        {
            var val_1;
            var val_4;
            val_1 = dheGroup;
            if(((int)val_1 & 65535) <= 4)
            {
                    var val_1 = 106069452 + ((int)(short)((dheGroup) & 0xFFFF)) << 2;
                val_1 = val_1 + 106069452;
            }
            else
            {
                    val_4 = 0;
                return (Org.BouncyCastle.Crypto.Parameters.DHParameters);
            }
        
        }
        public static bool ContainsDheCipherSuites(int[] cipherSuites)
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
            if((Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.IsDheCipherSuite(cipherSuite:  cipherSuites[0])) == false)
            {
                goto label_6;
            }
            
            val_3 = 1;
            return (bool)val_3;
            label_2:
            val_3 = 0;
            return (bool)val_3;
        }
        public static bool IsDheCipherSuite(int cipherSuite)
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if(cipherSuite > 171)
            {
                goto label_0;
            }
            
            if(cipherSuite > 69)
            {
                goto label_1;
            }
            
            if(cipherSuite > 51)
            {
                goto label_2;
            }
            
            int val_1 = cipherSuite - 17;
            if(val_1 >= 35)
            {
                goto label_26;
            }
            
            val_11 = val_1;
            val_12 = 25769803776;
            val_12 = 6;
            goto label_4;
            label_0:
            if(cipherSuite > 49297)
            {
                goto label_5;
            }
            
            if(cipherSuite > 196)
            {
                goto label_6;
            }
            
            int val_2 = cipherSuite - 178;
            if(val_2 >= 19)
            {
                goto label_26;
            }
            
            val_13 = val_2 & 524287;
            val_14 = 393216;
            val_14 = 6;
            goto label_19;
            label_1:
            if(cipherSuite > 136)
            {
                goto label_9;
            }
            
            int val_3 = cipherSuite - 103;
            if(val_3 >= 34)
            {
                goto label_26;
            }
            
            val_11 = val_3;
            val_12 = 25;
            label_4:
            val_11 = 12884901915 >> val_11;
            cipherSuite = val_11 & 1;
            return (bool)cipherSuite;
            label_5:
            if(cipherSuite > 52394)
            {
                goto label_11;
            }
            
            if((cipherSuite >> 1) == 24651)
            {
                goto label_20;
            }
            
            int val_5 = cipherSuite + 49309;
            val_15 = 1;
            if(val_5 <= 13)
            {
                    val_5 = val_15 << val_5;
                val_5 = val_5 & 13107;
                if(val_5 != 0)
            {
                    return (bool)val_15;
            }
            
            }
            
            val_16 = 52394;
            goto label_15;
            label_2:
            int val_6 = cipherSuite - 56;
            if(val_6 >= 14)
            {
                goto label_26;
            }
            
            val_13 = val_6 & 16383;
            val_14 = 12547;
            goto label_19;
            label_6:
            var val_11 = 49275;
            val_11 = cipherSuite + val_11;
            if(val_11 >= 22)
            {
                goto label_26;
            }
            
            val_13 = val_11 & 4194303;
            val_14 = 3145728;
            val_14 = 48;
            goto label_19;
            label_9:
            if((cipherSuite - 142) < 4)
            {
                goto label_20;
            }
            
            int val_8 = cipherSuite - 153;
            if(val_8 >= 11)
            {
                goto label_21;
            }
            
            val_13 = val_8 & 2047;
            val_14 = 1635;
            label_19:
            val_13 = 1635 >> val_13;
            cipherSuite = val_13 & 1;
            return (bool)cipherSuite;
            label_11:
            int val_9 = cipherSuite + 65279;
            val_15 = 1;
            if(val_9 <= 19)
            {
                    val_9 = val_15 << val_9;
                val_9 = val_9 & 786435;
                if(val_9 != 0)
            {
                    return (bool)val_15;
            }
            
            }
            
            val_16 = 52397;
            label_15:
            if(cipherSuite == 52397)
            {
                    return (bool)val_15;
            }
            
            goto label_26;
            label_21:
            if((cipherSuite & 4294967294) != 170)
            {
                goto label_26;
            }
            
            label_20:
            val_15 = 1;
            return (bool)val_15;
            label_26:
            val_15 = 0;
            return (bool)val_15;
        }
        public static bool AreCompatibleParameters(Org.BouncyCastle.Crypto.Parameters.DHParameters a, Org.BouncyCastle.Crypto.Parameters.DHParameters b)
        {
            var val_15;
            var val_16;
            val_15 = b;
            val_16 = a.P;
            Org.BouncyCastle.Math.BigInteger val_2 = val_15.P;
            if((val_16 & 1) == 0)
            {
                    return false;
            }
            
            val_16 = a.G;
            Org.BouncyCastle.Math.BigInteger val_4 = val_15.G;
            if((val_16 & 1) == 0)
            {
                    return false;
            }
            
            if(a.Q == null)
            {
                    return false;
            }
            
            if(val_15.Q == null)
            {
                    return false;
            }
            
            Org.BouncyCastle.Math.BigInteger val_7 = a.Q;
            Org.BouncyCastle.Math.BigInteger val_8 = val_15.Q;
            val_15 = ???;
            val_16 = ???;
            goto Org.BouncyCastle.Math.BigInteger.__il2cppRuntimeField_vtable;
        }
        public static byte[] CalculateDHBasicAgreement(Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters publicKey, Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters privateKey)
        {
            Org.BouncyCastle.Crypto.Agreement.DHBasicAgreement val_1 = new Org.BouncyCastle.Crypto.Agreement.DHBasicAgreement();
            if(val_1 != null)
            {
                    return Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(n:  val_1);
            }
            
            return Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(n:  val_1);
        }
        public static Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateDHKeyPair(Org.BouncyCastle.Security.SecureRandom random, Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams)
        {
            Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters val_2 = new Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters(random:  random, parameters:  dhParams);
            if(new Org.BouncyCastle.Crypto.Generators.DHBasicKeyPairGenerator() == null)
            {
                
            }
        
        }
        public static Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters GenerateEphemeralClientKeyExchange(Org.BouncyCastle.Security.SecureRandom random, Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams, System.IO.Stream output)
        {
            var val_9;
            var val_10;
            Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair val_1 = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.GenerateDHKeyPair(random:  random, dhParams:  dhParams);
            val_9 = val_1.Public;
            if(val_9 != null)
            {
                    val_9 = 0;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.WriteDHParameter(x:  val_9.Y, output:  output);
            if(val_1.Private == null)
            {
                    return (Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters)val_10;
            }
            
            val_10 = 0;
            return (Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters)val_10;
        }
        public static Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters GenerateEphemeralServerKeyExchange(Org.BouncyCastle.Security.SecureRandom random, Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams, System.IO.Stream output)
        {
            Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters val_8;
            var val_9;
            Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair val_1 = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.GenerateDHKeyPair(random:  random, dhParams:  dhParams);
            val_8 = val_1.Public;
            if(val_8 != null)
            {
                    val_8 = 0;
            }
            
            new Org.BouncyCastle.Crypto.Tls.ServerDHParams() = new Org.BouncyCastle.Crypto.Tls.ServerDHParams(publicKey:  val_8);
            if(val_1.Private == null)
            {
                    return (Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters)val_9;
            }
            
            val_9 = 0;
            return (Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters)val_9;
        }
        public static Org.BouncyCastle.Crypto.Parameters.DHParameters ValidateDHParameters(Org.BouncyCastle.Crypto.Parameters.DHParameters parameters)
        {
            var val_9;
            var val_10;
            var val_11;
            if(parameters != null)
            {
                    val_9 = parameters.P;
            }
            else
            {
                    val_9 = 0.P;
            }
            
            Org.BouncyCastle.Math.BigInteger val_3 = parameters.G;
            if((val_9.IsProbablePrime(certainty:  2)) != false)
            {
                    val_10 = null;
                val_10 = null;
                if(((val_3.CompareTo(value:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.Two)) & 2147483648) == 0)
            {
                    val_11 = null;
                val_11 = null;
                if((val_3.CompareTo(value:  val_9.Subtract(n:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.Two))) < 1)
            {
                    return (Org.BouncyCastle.Crypto.Parameters.DHParameters)parameters;
            }
            
            }
            
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_8 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
        }
        public static Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters ValidateDHPublicKey(Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters key)
        {
            var val_9;
            Org.BouncyCastle.Crypto.Parameters.DHParameters val_1 = key.Parameters;
            Org.BouncyCastle.Crypto.Parameters.DHParameters val_2 = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ValidateDHParameters(parameters:  val_1);
            Org.BouncyCastle.Math.BigInteger val_3 = key.Y;
            if(((val_3.CompareTo(value:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.Two)) & 2147483648) == 0)
            {
                    val_9 = null;
                val_9 = null;
                if((val_3.CompareTo(value:  val_1.P.Subtract(n:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.Two))) < 1)
            {
                    return (Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters)key;
            }
            
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_8 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
        }
        public static Org.BouncyCastle.Math.BigInteger ReadDHParameter(System.IO.Stream input)
        {
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input:  input));
        }
        public static void WriteDHParameter(Org.BouncyCastle.Math.BigInteger x, System.IO.Stream output)
        {
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(buf:  Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(n:  x), output:  output);
        }
        protected TlsDHUtilities()
        {
        
        }
        private static TlsDHUtilities()
        {
            null = null;
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.Two = Org.BouncyCastle.Math.BigInteger.Two;
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe2432_p = "FFFFFFFFFFFFFFFFADF85458A2BB4A9AAFDC5620273D3CF1D8B9C583CE2D3695A9E13641146433FBCC939DCE249B3EF97D2FE363630C75D8F681B202AEC4617AD3DF1ED5D5FD65612433F51F5F066ED0856365553DED1AF3B557135E7F57C935984F0C70E0E68B77E2A689DAF3EFE8721DF158A136ADE73530ACCA4F483A797ABC0AB182B324FB61D108A94BB2C8E3FBB96ADAB760D7F4681D4F42A3DE394DF4AE56EDE76372BB190B07A7C8EE0A6D709E02FCE1CDF7E2ECC03404CD28342F619172FE9CE98583FF8E4F1232EEF28183C3FE3B1B4C6FAD733BB5FCBC2EC22005C58EF1837D1683B2C6F34A26C1B2EFFA886B4238611FCFDCDE355B3B6519035BBC34F4DEF99C023861B46FC9D6E6C9077AD91D2691F7F7EE598CB0FAC186D91CAEFE13098533C8B3FFFFFFFFFFFFFFFF";
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe2432 = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.FromSafeP(hexP:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe2432_p);
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe3072_p = "FFFFFFFFFFFFFFFFADF85458A2BB4A9AAFDC5620273D3CF1D8B9C583CE2D3695A9E13641146433FBCC939DCE249B3EF97D2FE363630C75D8F681B202AEC4617AD3DF1ED5D5FD65612433F51F5F066ED0856365553DED1AF3B557135E7F57C935984F0C70E0E68B77E2A689DAF3EFE8721DF158A136ADE73530ACCA4F483A797ABC0AB182B324FB61D108A94BB2C8E3FBB96ADAB760D7F4681D4F42A3DE394DF4AE56EDE76372BB190B07A7C8EE0A6D709E02FCE1CDF7E2ECC03404CD28342F619172FE9CE98583FF8E4F1232EEF28183C3FE3B1B4C6FAD733BB5FCBC2EC22005C58EF1837D1683B2C6F34A26C1B2EFFA886B4238611FCFDCDE355B3B6519035BBC34F4DEF99C023861B46FC9D6E6C9077AD91D2691F7F7EE598CB0FAC186D91CAEFE130985139270B4130C93BC437944F4FD4452E2D74DD364F2E21E71F54BFF5CAE82AB9C9DF69EE86D2BC522363A0DABC521979B0DEADA1DBF9A42D5C4484E0ABCD06BFA53DDEF3C1B20EE3FD59D7C25E41D2B66C62E37FFFFFFFFFFFFFFFF";
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe3072 = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.FromSafeP(hexP:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe3072_p);
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe4096_p = "FFFFFFFFFFFFFFFFADF85458A2BB4A9AAFDC5620273D3CF1D8B9C583CE2D3695A9E13641146433FBCC939DCE249B3EF97D2FE363630C75D8F681B202AEC4617AD3DF1ED5D5FD65612433F51F5F066ED0856365553DED1AF3B557135E7F57C935984F0C70E0E68B77E2A689DAF3EFE8721DF158A136ADE73530ACCA4F483A797ABC0AB182B324FB61D108A94BB2C8E3FBB96ADAB760D7F4681D4F42A3DE394DF4AE56EDE76372BB190B07A7C8EE0A6D709E02FCE1CDF7E2ECC03404CD28342F619172FE9CE98583FF8E4F1232EEF28183C3FE3B1B4C6FAD733BB5FCBC2EC22005C58EF1837D1683B2C6F34A26C1B2EFFA886B4238611FCFDCDE355B3B6519035BBC34F4DEF99C023861B46FC9D6E6C9077AD91D2691F7F7EE598CB0FAC186D91CAEFE130985139270B4130C93BC437944F4FD4452E2D74DD364F2E21E71F54BFF5CAE82AB9C9DF69EE86D2BC522363A0DABC521979B0DEADA1DBF9A42D5C4484E0ABCD06BFA53DDEF3C1B20EE3FD59D7C25E41D2B669E1EF16E6F52C3164DF4FB7930E9E4E58857B6AC7D5F42D69F6D187763CF1D5503400487F55BA57E31CC7A7135C886EFB4318AED6A1E012D9E6832A907600A918130C46DC778F971AD0038092999A333CB8B7A1A1DB93D7140003C2A4ECEA9F98D0ACC0A8291CDCEC97DCF8EC9B55A7F88A46B4DB5A851F44182E1C68A007E5E655F6AFFFFFFFFFFFFFFFF";
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe4096 = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.FromSafeP(hexP:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe4096_p);
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe6144_p = "FFFFFFFFFFFFFFFFADF85458A2BB4A9AAFDC5620273D3CF1D8B9C583CE2D3695A9E13641146433FBCC939DCE249B3EF97D2FE363630C75D8F681B202AEC4617AD3DF1ED5D5FD65612433F51F5F066ED0856365553DED1AF3B557135E7F57C935984F0C70E0E68B77E2A689DAF3EFE8721DF158A136ADE73530ACCA4F483A797ABC0AB182B324FB61D108A94BB2C8E3FBB96ADAB760D7F4681D4F42A3DE394DF4AE56EDE76372BB190B07A7C8EE0A6D709E02FCE1CDF7E2ECC03404CD28342F619172FE9CE98583FF8E4F1232EEF28183C3FE3B1B4C6FAD733BB5FCBC2EC22005C58EF1837D1683B2C6F34A26C1B2EFFA886B4238611FCFDCDE355B3B6519035BBC34F4DEF99C023861B46FC9D6E6C9077AD91D2691F7F7EE598CB0FAC186D91CAEFE130985139270B4130C93BC437944F4FD4452E2D74DD364F2E21E71F54BFF5CAE82AB9C9DF69EE86D2BC522363A0DABC521979B0DEADA1DBF9A42D5C4484E0ABCD06BFA53DDEF3C1B20EE3FD59D7C25E41D2B669E1EF16E6F52C3164DF4FB7930E9E4E58857B6AC7D5F42D69F6D187763CF1D5503400487F55BA57E31CC7A7135C886EFB4318AED6A1E012D9E6832A907600A918130C46DC778F971AD0038092999A333CB8B7A1A1DB93D7140003C2A4ECEA9F98D0ACC0A8291CDCEC97DCF8EC9B55A7F88A46B4DB5A851F44182E1C68A007E5E0DD9020BFD64B645036C7A4E677D2C38532A3A23BA4442CAF53EA63BB454329B7624C8917BDD64B1C0FD4CB38E8C334C701C3ACDAD0657FCCFEC719B1F5C3E4E46041F388147FB4CFDB477A52471F7A9A96910B855322EDB6340D8A00EF092350511E30ABEC1FFF9E3A26E7FB29F8C183023C3587E38DA0077D9B4763E4E4B94B2BBC194C6651E77CAF992EEAAC0232A281BF6B3A739C1226116820AE8DB5847A67CBEF9C9091B462D538CD72B03746AE77F5E62292C311562A846505DC82DB854338AE49F5235C95B91178CCF2DD5CACEF403EC9D1810C6272B045B3B71F9DC6B80D63FDD4A8E9ADB1E6962A69526D43161C1A41D570D7938DAD4A40E329CD0E40E65FFFFFFFFFFFFFFFF";
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe6144 = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.FromSafeP(hexP:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe6144_p);
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe8192_p = "FFFFFFFFFFFFFFFFADF85458A2BB4A9AAFDC5620273D3CF1D8B9C583CE2D3695A9E13641146433FBCC939DCE249B3EF97D2FE363630C75D8F681B202AEC4617AD3DF1ED5D5FD65612433F51F5F066ED0856365553DED1AF3B557135E7F57C935984F0C70E0E68B77E2A689DAF3EFE8721DF158A136ADE73530ACCA4F483A797ABC0AB182B324FB61D108A94BB2C8E3FBB96ADAB760D7F4681D4F42A3DE394DF4AE56EDE76372BB190B07A7C8EE0A6D709E02FCE1CDF7E2ECC03404CD28342F619172FE9CE98583FF8E4F1232EEF28183C3FE3B1B4C6FAD733BB5FCBC2EC22005C58EF1837D1683B2C6F34A26C1B2EFFA886B4238611FCFDCDE355B3B6519035BBC34F4DEF99C023861B46FC9D6E6C9077AD91D2691F7F7EE598CB0FAC186D91CAEFE130985139270B4130C93BC437944F4FD4452E2D74DD364F2E21E71F54BFF5CAE82AB9C9DF69EE86D2BC522363A0DABC521979B0DEADA1DBF9A42D5C4484E0ABCD06BFA53DDEF3C1B20EE3FD59D7C25E41D2B669E1EF16E6F52C3164DF4FB7930E9E4E58857B6AC7D5F42D69F6D187763CF1D5503400487F55BA57E31CC7A7135C886EFB4318AED6A1E012D9E6832A907600A918130C46DC778F971AD0038092999A333CB8B7A1A1DB93D7140003C2A4ECEA9F98D0ACC0A8291CDCEC97DCF8EC9B55A7F88A46B4DB5A851F44182E1C68A007E5E0DD9020BFD64B645036C7A4E677D2C38532A3A23BA4442CAF53EA63BB454329B7624C8917BDD64B1C0FD4CB38E8C334C701C3ACDAD0657FCCFEC719B1F5C3E4E46041F388147FB4CFDB477A52471F7A9A96910B855322EDB6340D8A00EF092350511E30ABEC1FFF9E3A26E7FB29F8C183023C3587E38DA0077D9B4763E4E4B94B2BBC194C6651E77CAF992EEAAC0232A281BF6B3A739C1226116820AE8DB5847A67CBEF9C9091B462D538CD72B03746AE77F5E62292C311562A846505DC82DB854338AE49F5235C95B91178CCF2DD5CACEF403EC9D1810C6272B045B3B71F9DC6B80D63FDD4A8E9ADB1E6962A69526D43161C1A41D570D7938DAD4A40E329CCFF46AAA36AD004CF600C8381E425A31D951AE64FDB23FCEC9509D43687FEB69EDD1CC5E0B8CC3BDF64B10EF86B63142A3AB8829555B2F747C932665CB2C0F1CC01BD70229388839D2AF05E454504AC78B7582822846C0BA35C35F5C59160CC046FD8251541FC68C9C86B022BB7099876A460E7451A8A93109703FEE1C217E6C3826E52C51AA691E0E423CFC99E9E31650C1217B624816CDAD9A95F9D5B8019488D9C0A0A1FE3075A577E23183F81D4A3F2FA4571EFC8CE0BA8A4FE8B6855DFE72B0A66EDED2FBABFBE58A30FAFABE1C5D71A87E2F741EF8C1FE86FEA6BBFDE530677F0D97D11D49F7A8443D0822E506A9F4614E011E2A94838FF88CD68C8BB7C5C6424CFFFFFFFFFFFFFFFF";
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe8192 = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.FromSafeP(hexP:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe8192_p);
        }
    
    }

}
