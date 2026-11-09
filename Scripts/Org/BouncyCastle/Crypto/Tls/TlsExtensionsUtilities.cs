using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class TlsExtensionsUtilities
    {
        // Methods
        public static System.Collections.IDictionary EnsureExtensionsInitialised(System.Collections.IDictionary extensions)
        {
            if(extensions == null)
            {
                    return Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            }
            
            return (System.Collections.IDictionary)extensions;
        }
        public static void AddEncryptThenMacExtension(System.Collections.IDictionary extensions)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            extensions.set_Item(key:  22, value:  Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData());
        }
        public static void AddExtendedMasterSecretExtension(System.Collections.IDictionary extensions)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            extensions.set_Item(key:  23, value:  Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData());
        }
        public static void AddHeartbeatExtension(System.Collections.IDictionary extensions, Org.BouncyCastle.Crypto.Tls.HeartbeatExtension heartbeatExtension)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            extensions.set_Item(key:  15, value:  Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateHeartbeatExtension(heartbeatExtension:  heartbeatExtension));
        }
        public static void AddMaxFragmentLengthExtension(System.Collections.IDictionary extensions, byte maxFragmentLength)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            extensions.set_Item(key:  1, value:  Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateMaxFragmentLengthExtension(maxFragmentLength:  maxFragmentLength));
        }
        public static void AddPaddingExtension(System.Collections.IDictionary extensions, int dataLength)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            extensions.set_Item(key:  21, value:  Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreatePaddingExtension(dataLength:  dataLength));
        }
        public static void AddServerNameExtension(System.Collections.IDictionary extensions, Org.BouncyCastle.Crypto.Tls.ServerNameList serverNameList)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            extensions.set_Item(key:  0, value:  Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateServerNameExtension(serverNameList:  serverNameList));
        }
        public static void AddStatusRequestExtension(System.Collections.IDictionary extensions, Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest statusRequest)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            extensions.set_Item(key:  5, value:  Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateStatusRequestExtension(statusRequest:  statusRequest));
        }
        public static void AddTruncatedHMacExtension(System.Collections.IDictionary extensions)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            extensions.set_Item(key:  4, value:  Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData());
        }
        public static Org.BouncyCastle.Crypto.Tls.HeartbeatExtension GetHeartbeatExtension(System.Collections.IDictionary extensions)
        {
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  extensions, extensionType:  15);
            if(val_1 == null)
            {
                    return (Org.BouncyCastle.Crypto.Tls.HeartbeatExtension)val_1;
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadHeartbeatExtension(extensionData:  val_1);
        }
        public static short GetMaxFragmentLengthExtension(System.Collections.IDictionary extensions)
        {
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  extensions, extensionType:  1);
            if(val_1 == null)
            {
                    return 65535;
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadMaxFragmentLengthExtension(extensionData:  val_1);
        }
        public static int GetPaddingExtension(System.Collections.IDictionary extensions)
        {
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  extensions, extensionType:  21);
            if(val_1 == null)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadPaddingExtension(extensionData:  val_1);
        }
        public static Org.BouncyCastle.Crypto.Tls.ServerNameList GetServerNameExtension(System.Collections.IDictionary extensions)
        {
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  extensions, extensionType:  0);
            if(val_1 == null)
            {
                    return (Org.BouncyCastle.Crypto.Tls.ServerNameList)val_1;
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadServerNameExtension(extensionData:  val_1);
        }
        public static Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest GetStatusRequestExtension(System.Collections.IDictionary extensions)
        {
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  extensions, extensionType:  5);
            if(val_1 == null)
            {
                    return (Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest)val_1;
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadStatusRequestExtension(extensionData:  val_1);
        }
        public static bool HasEncryptThenMacExtension(System.Collections.IDictionary extensions)
        {
            var val_3;
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  extensions, extensionType:  22);
            if(val_1 == null)
            {
                    return (bool)val_3;
            }
            
            bool val_2 = Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData:  val_1);
            val_3 = 1;
            return (bool)val_3;
        }
        public static bool HasExtendedMasterSecretExtension(System.Collections.IDictionary extensions)
        {
            var val_3;
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  extensions, extensionType:  23);
            if(val_1 == null)
            {
                    return (bool)val_3;
            }
            
            bool val_2 = Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData:  val_1);
            val_3 = 1;
            return (bool)val_3;
        }
        public static bool HasTruncatedHMacExtension(System.Collections.IDictionary extensions)
        {
            var val_3;
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  extensions, extensionType:  4);
            if(val_1 == null)
            {
                    return (bool)val_3;
            }
            
            bool val_2 = Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData:  val_1);
            val_3 = 1;
            return (bool)val_3;
        }
        public static byte[] CreateEmptyExtensionData()
        {
            null = null;
            return (System.Byte[])Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
        }
        public static byte[] CreateEncryptThenMacExtension()
        {
            return Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
        }
        public static byte[] CreateExtendedMasterSecretExtension()
        {
            return Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
        }
        public static byte[] CreateHeartbeatExtension(Org.BouncyCastle.Crypto.Tls.HeartbeatExtension heartbeatExtension)
        {
            if(heartbeatExtension != null)
            {
                    if(new System.IO.MemoryStream() != null)
            {
                goto typeof(System.IO.MemoryStream).__il2cppRuntimeField_388;
            }
            
            }
            else
            {
                    Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
            }
        
        }
        public static byte[] CreateMaxFragmentLengthExtension(byte maxFragmentLength)
        {
            byte[] val_1 = new byte[1];
            val_1[0] = maxFragmentLength;
            return (System.Byte[])val_1;
        }
        public static byte[] CreatePaddingExtension(int dataLength)
        {
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i:  dataLength);
            byte[] val_1 = new byte[0];
        }
        public static byte[] CreateServerNameExtension(Org.BouncyCastle.Crypto.Tls.ServerNameList serverNameList)
        {
            if(serverNameList != null)
            {
                    if(new System.IO.MemoryStream() != null)
            {
                goto typeof(System.IO.MemoryStream).__il2cppRuntimeField_388;
            }
            
            }
            else
            {
                    Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
            }
        
        }
        public static byte[] CreateStatusRequestExtension(Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest statusRequest)
        {
            if(statusRequest != null)
            {
                    if(new System.IO.MemoryStream() != null)
            {
                goto typeof(System.IO.MemoryStream).__il2cppRuntimeField_388;
            }
            
            }
            else
            {
                    Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
            }
        
        }
        public static byte[] CreateTruncatedHMacExtension()
        {
            return Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
        }
        private static bool ReadEmptyExtensionData(byte[] extensionData)
        {
            var val_3;
            if(extensionData == null)
            {
                goto label_1;
            }
            
            if(extensionData.Length != 0)
            {
                goto label_2;
            }
            
            return true;
            label_1:
            System.ArgumentNullException val_1 = null;
            val_3 = val_1;
            val_1 = new System.ArgumentNullException(paramName:  "extensionData");
            goto label_3;
            label_2:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = null;
            val_3 = val_2;
            val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
            label_3:
        }
        public static bool ReadEncryptThenMacExtension(byte[] extensionData)
        {
            bool val_1 = Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData:  extensionData);
            return true;
        }
        public static bool ReadExtendedMasterSecretExtension(byte[] extensionData)
        {
            bool val_1 = Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData:  extensionData);
            return true;
        }
        public static Org.BouncyCastle.Crypto.Tls.HeartbeatExtension ReadHeartbeatExtension(byte[] extensionData)
        {
            if(extensionData != null)
            {
                    System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  extensionData, writable:  false);
                Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf:  val_1);
                return (Org.BouncyCastle.Crypto.Tls.HeartbeatExtension)Org.BouncyCastle.Crypto.Tls.HeartbeatExtension.Parse(input:  val_1);
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "extensionData");
        }
        public static short ReadMaxFragmentLengthExtension(byte[] extensionData)
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
            
            return (short)extensionData[0];
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
        public static int ReadPaddingExtension(byte[] extensionData)
        {
            int val_3;
            if(extensionData == null)
            {
                goto label_1;
            }
            
            val_3 = extensionData.Length;
            if(val_3 < 1)
            {
                    return val_3;
            }
            
            label_5:
            if(extensionData[0] != 0)
            {
                goto label_4;
            }
            
            val_3 = extensionData.Length;
            if((0 + 1) < val_3)
            {
                goto label_5;
            }
            
            return val_3;
            label_4:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
            label_6:
            label_1:
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "extensionData");
            goto label_6;
        }
        public static Org.BouncyCastle.Crypto.Tls.ServerNameList ReadServerNameExtension(byte[] extensionData)
        {
            if(extensionData != null)
            {
                    System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  extensionData, writable:  false);
                Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf:  val_1);
                return (Org.BouncyCastle.Crypto.Tls.ServerNameList)Org.BouncyCastle.Crypto.Tls.ServerNameList.Parse(input:  val_1);
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "extensionData");
        }
        public static Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest ReadStatusRequestExtension(byte[] extensionData)
        {
            if(extensionData != null)
            {
                    System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  extensionData, writable:  false);
                Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf:  val_1);
                return (Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest)Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest.Parse(input:  val_1);
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "extensionData");
        }
        public static bool ReadTruncatedHMacExtension(byte[] extensionData)
        {
            bool val_1 = Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData:  extensionData);
            return true;
        }
        protected TlsExtensionsUtilities()
        {
        
        }
    
    }

}
